using Business.Concrate;
using DataAccsess.Concrate.EntityFramework;
using Etities.Concrate;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {


            ColorManager color = new ColorManager(new EfColorDal());
            foreach (var colors in color.GetById(2))
            {
                Console.WriteLine(colors.ColorName);
            }
            Console.WriteLine("--------------");
            Console.WriteLine("--------------");
            Console.WriteLine("--------------");
            CostomerManager costomer = new CostomerManager(new EfCostomerDal());
            foreach (var costomers in costomer.GetById(4))
            {
                Console.WriteLine(costomers.CustFirstName);
            }
            {

            }
            Console.WriteLine( "------------");
            Console.WriteLine( "------------");
            Console.WriteLine( "------------");
            BrandManager brand = new    BrandManager(new  EfBrandDal());        
            foreach (var brands in brand.GetById(5 ))
            {
                Console.WriteLine(brands.BrandName);
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("--------------------");
            Console.WriteLine("--------------------");
            CarManager car = new CarManager(new EfCarDal());
            foreach (var cars in car.GetByPrice(500,1000))
            {
                Console.WriteLine(cars.Brand +" " + cars.Color + " " + cars.DailyPrice);
            }
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
            foreach (var cars in car.GettAll( ))
            {
                Console.WriteLine(cars.Brand + " " + cars.Color + " " + cars.DailyPrice);
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("--------------------");
            Console.WriteLine("--------------------");
            MotorcycleManager motorcycle = new MotorcycleManager(new EfMotorcycleDal());
            foreach (var motors in motorcycle.GettAll())
            {
                Console.WriteLine(motors.Brand + " " + motors.Model);
            }
        }
    }
}
