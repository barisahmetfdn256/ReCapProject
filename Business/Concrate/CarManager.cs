using Business.Abstract;
using DataAccsess.Abstract;
using Etities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ReCapProject.Business.Concrete
{
    class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car entity)
        {
            _carDal.Add(entity);
        }

        public void Delete(Car entity)
        {
            _carDal.Delete(entity);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetALL(Expression<Func<Car, bool>> filter = null)
        {
            return _carDal.GetALL();
        }

        public List<Car> GetAll()
        {
            return _carDal.GetALL();
        }

        public List<Car> GetByColor(string color)
        {
            return _carDal.GetALL(p => p.Color == color);
        }

        public List<Car> GetById(int id)
        {
            return _carDal.GetALL(p => p.CarId == id);
        }

        public void Update(Car entity)
        {
            _carDal.Update(entity);
        }
    }
}