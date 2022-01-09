using Business.Concrate;
using DataAccess.Concrete.EntityFramework;
using DataAccsess.Concrate.EntityFramework;
using Etities.Concrate;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GettAll();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandId    +" " + car.ColorId + " " + car.DailyPrice );
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
