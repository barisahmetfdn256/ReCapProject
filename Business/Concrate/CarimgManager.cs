using Business.Abstract;
using Business.Conctants;
using Business.Constants;
using Business.ValidationRules.FluentRules;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilites.Business;
using Core.Utilites.Helper.FileHelper;
using Core.Utilities.Results;
using DataAccsess.Abstract;
using Etities.Concrate;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CarimgManager : ICarimgService
    {
        ICarimgDal _carimgDal;
        IFileHelper _fileHelper;

        public CarimgManager(ICarimgDal carimgDal,IFileHelper fileHelper)
        {
            _carimgDal = carimgDal;
            _fileHelper = fileHelper;
        }

        [ValidationAspect(typeof(CarimgValiator))]
        public IResult Add(IFormFile formFile, Carimg carimg)
        {
            ValidationTool.Validate(new CarimgValiator(), carimg);
            var carimgCount = _carimgDal.GetAll(c => c.CarId == carimg.CarId).Count;
            if (carimgCount >= 5)
            {
                return new ErrorResult(Messages.Maximg);
            }
        
           
            carimg.ImgPath = _fileHelper.Upload(formFile,FileConctants.PathConctants + carimg.ImgPath);
            carimg.Date=DateTime.Now;
            _carimgDal.Add(carimg);
            return new SuccessResult(Messages.ImgAdded);
        }

        public IResult Delete(Carimg carimg)
        {
            var carimgCount = _carimgDal.GetAll(c => c.CarId == carimg.CarId).Count;
            if (carimgCount <= 1 )
            {
                return new ErrorResult(Messages.Maximg);
            }

            _fileHelper.Delete(carimg.ImgPath);
            carimg.Date = DateTime.Now;
            _carimgDal.Delete(carimg);
            return new SuccessResult(Messages.ImgDeleted);  
        }

        public IDataResult<List<Carimg>> GetAll()
        {
            var result = _carimgDal.GetAll();
            if (result.Count == 0)
            {
                return new ErrorDataResult<List<Carimg>>(Messages.İmgNull);
            }
            return new SuccessDataResult<List<Carimg>>(_carimgDal.GetAll());
        } 

        public IDataResult<List<Carimg>> GetByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Carimg>>(_carimgDal.GetAll(b => b.Id == brandId));
        }

        public IDataResult<List<Carimg>> GetByCarId(int carId)
        {
        
            return new SuccessDataResult<List<Carimg>>(_carimgDal.GetAll(c => c.CarId == carId));
        }

        public IDataResult<Carimg> GetByImgId(int imgId)
        {
            return new SuccessDataResult<Carimg>(_carimgDal.Get( c => c.Id == imgId ));
        }

        public IResult Update(IFormFile formFile, Carimg carimg)
        {
            var imgentity = GetByImgId(carimg.Id).Data;

            imgentity.ImgPath = _fileHelper.Update(formFile, FileConctants.PathConctants + carimg.ImgPath, FileConctants.PathConctants);
            imgentity.Date = DateTime.Now; 
            _carimgDal.Update(imgentity);
            return new SuccessResult(Messages.ImgUpdated);
        }

        
    }
}
