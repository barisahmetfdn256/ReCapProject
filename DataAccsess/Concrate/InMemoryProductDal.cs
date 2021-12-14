using DataAccsess.Abstract;
using Etities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ReCapProject.DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,Brand ="BMW",Model="M4",ModelYear=2020,CarPrice="1.850.000",DailyPrice="2.500",WeeklyPrice="15.000",Location="İstanbul/Pendik",Color="Mustard"},
                new Car{CarId=2,Brand ="Wolswagen",Model="Polo",ModelYear=2017,CarPrice="300.000",DailyPrice="1.200",WeeklyPrice="5.000",Location="İstanbul/Üsküdar",Color="White"},
                new Car{CarId=3,Brand ="Toyata",Model="Colara",ModelYear=2000,CarPrice="900",DailyPrice="1.200",WeeklyPrice="4.000",Location="İstanbul/Esenyurt",Color="Grey"},
                new Car{CarId=3,Brand ="Prsche",Model="Panamera",ModelYear=2021,CarPrice="2.000.000",DailyPrice="3.000",WeeklyPrice="20.000",Location="İstanbul/Etiler",Color="NavyBlue"},
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine("Araç Eklendi");
        }

        public void Delete(Car car)
        {
            _cars.Remove(car);
            Console.WriteLine("Araç Silindi");

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetALL(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByColor(string color)
        {
            return _cars.Where(c => c.Color == color).ToList();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.CarId == id).ToList();
        }



        public void Update(Car car)
        {
            Console.WriteLine("Araç Güncellendi");

            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Color = car.Color;
            carToUpdate.Brand = car.Brand;
        }
    }
}