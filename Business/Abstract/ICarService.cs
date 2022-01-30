using Core.Entities;
using Core.Utilities.Results;
using Etities.Concrate;
using Etities.Concrate.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public  interface ICarService
    {
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<Car>> GettAll();
        IDataResult<List<Car>> GetByColorId(int colorId);
        IDataResult<List<Car>> GetByPrice(int min , int max);
        IDataResult<List<Car>> GetByBrandId(int brandId);
        IResult Add(Car car);
        IResult Delete(Car car);
        IDataResult<Car> GetById(); 

    }
}
