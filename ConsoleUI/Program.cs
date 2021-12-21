using Business.Concrate;
using DataAccess.Concrete.EntityFramework;
using DataAccsess.Concrate.EntityFramework;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName +" " + car.ColorName + " " + car.DailyPrice );
                }
            }
        }
    }
}
