using Business.Concrate;
using DataAccsess.Concrate.EntityFramework;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager car = new CarManager(new EfCarDal());
            foreach (var cars in car.GettAll())
            {
                Console.WriteLine(cars.Brand +" " + cars.Model + " " + cars.DailyPrice +" " + cars.Color)   ;
            }
            Console.WriteLine("zazazaza");
        }
    }
}
