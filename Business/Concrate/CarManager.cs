using Business.Abstract;
using Business.Constants;
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

        public IResult Add(Car car)
        {

            if (car.Description.Length < 5 )
            {
                return new ErrorResult(Messages.CarInvalid);
            }
            return new Result(true , Messages.CarAdded);
            
        }

        public IDataResult<List<Car>> GetByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll(c=>c.BrandId == brandId));
        }

        public IDataResult<List<Car>> GetByColor(int colorId)
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
            if (DateTime.Now.Hour == 10)
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
