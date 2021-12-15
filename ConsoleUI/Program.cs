using Business.Concrate;
using DataAccsess.Concrate.EntityFramework;
using Etities.Concrate;
using ReCapProject.Business.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {


            CarManager car = new CarManager(new EfCarDal());

            foreach (var cars in car.GetALL())
            {
                Console.WriteLine(cars.Brand);
            }

            ColorManager color = new ColorManager(new EfColorDal());
            foreach (var colors in color.GetAll())
            {
                Console.WriteLine(colors.ColorName);
            }
        }
    }
}
