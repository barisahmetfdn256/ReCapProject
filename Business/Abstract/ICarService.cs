using Etities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public  interface ICarService
    {
        List<Car> GettAll();
        List<Car> GetByColor(string color);
        List<Car> GetByPrice(int min , int max);
        List<Car> GetByBrand(string brand);
        void Add(Car entity);
        void Delete(Car entity);
        void Update(Car entity);
    }
}
