using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccsess.Abstract;
using Etities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length < 3)
            {
                return new ErrorResult(Messages.InvalidBrand);
            }
            return new Result(true , Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            if (brand.BrandName.Length < 3)
            {
                return new ErrorResult(Messages.InvalidBrand);
            }
            return new Result(true, Messages.BrandAdded);
        }


        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>();
        }

        public IDataResult<List<Brand>> GetByBrand(string brand)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(b=>b.BrandName == brand));
        }

        public IDataResult<Brand> GetByİd(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get());
        }

        public IResult Update(Brand brand)
        {
            if (brand.BrandName.Length < 3)
            {
                return new ErrorResult(Messages.InvalidBrand);
            }
            return new Result(true, Messages.BrandAdded);
        }
    }
}

