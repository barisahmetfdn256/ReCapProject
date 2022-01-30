using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentRules;
using Core.Aspects.Autofac.Chasing;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccsess.Abstract;
using Etities.Concrate;
using Etities.Concrate.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CarManager : ICarService
    {
        ICarDal _cardal;

        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }

        [SecuredOperation("admin")]
        //[ValidationAspect(typeof(CarValidator))]
        //[CacheRemoveAspect("ICarService.Get")]
        //[PerformanceAspect(5)]
        public IResult Add(Car car)
        {
            ValidationTool.Validate(new CarValidator(), car);
            _cardal.Add(car);
            return new Result(true, Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _cardal.Delete(car);
            return new Result(true , Messages.CarDeleted);
        }

        [CacheAspect(duration: 25)]
        public IDataResult<List<Car>> GetByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll(c=>c.BrandId == brandId));
        }

        public IDataResult<List<Car>> GetByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll(c => c.ColorId == colorId));
        }

        public IDataResult<Car> GetById()
        {
           return new SuccessDataResult<Car>(_cardal.Get());
        }

        public IDataResult<List<Car>> GetByPrice(int min, int max)
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll(c => c.DailyPrice>=min && c.DailyPrice <= max));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_cardal.GetCarDetail());
        }

        public IDataResult<List<Car>> GettAll()
        {
            if (DateTime.Now.Hour == 1)
            {
                return new ErrorDataResult<List<Car>>(Messages.MainteanceTime);
            }
            else
            {
                return new SuccessDataResult<List<Car>>(_cardal.GetAll(), Messages.CarsListed);
            }
        }
    }
}
