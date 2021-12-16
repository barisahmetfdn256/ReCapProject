using Business.Abstract;
using DataAccsess.Abstract;
using Etities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car entitiy)
        {
            _carDal.Add(entitiy);
        }

        public void Delete(Car entity)
        {
            _carDal.Delete(entity);
        }

        public List<Car> GetByBrand(string brand)
        {
            return _carDal.GetALL(p => p.Brand == brand);
        }

        public List<Car> GetByColor(string color)
        {
            return _carDal.GetALL(p=>p.Color==color);
        }

        public List<Car> GetByPrice(int min, int max)
        {
            return _carDal.GetALL(p=>p.DailyPrice >= min && p.DailyPrice < max);
        }


        public List<Car> GettAll()
        {
            return _carDal.GetALL();
        }

        public void Update(Car entity)
        {
            _carDal.Add(entity);
        }
    }
}
    
