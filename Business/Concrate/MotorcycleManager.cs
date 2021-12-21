using Business.Abstract;
using DataAccsess.Abstract;
using Etities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class MotorcycleManager : IMotorcycleService
    {
        IMotorcycleDal _motorcycleDal;
        public MotorcycleManager(IMotorcycleDal motorcycleDal)
        {
            _motorcycleDal = motorcycleDal;
        }
        public void Add(Motorcycle entity)
        {
            _motorcycleDal.Add(entity);
        }

        public void Delete(Motorcycle entity)
        {
            _motorcycleDal.Delete(entity);
        }

        public List<Motorcycle> GetByBrand(string brand)
        {
            return _motorcycleDal.GetAll(p=>p.Brand==brand);
        }

        public List<Motorcycle> GetByColor(string color)
        {
            return _motorcycleDal.GetAll(p=>p.Color==color);
        }

        public List<Motorcycle> GetByPrice(int min, int max)
        {
            return _motorcycleDal.GetAll(p=>p.DailyPrice >= min && p.DailyPrice<=max);
        }

        public List<Motorcycle> GettAll()
        {
            return _motorcycleDal.GetAll();
        }


        public void Update(Motorcycle entity)
        {
            _motorcycleDal.Update(entity);
        }
    }
}
