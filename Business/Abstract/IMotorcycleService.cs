using Etities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface  IMotorcycleService
    {
        List<Motorcycle> GettAll();
        List<Motorcycle> GetByColor(string color);
        List<Motorcycle> GetByPrice(int min, int max);
        List<Motorcycle> GetByBrand(string brand);
        void Add(Motorcycle entity);
        void Delete(Motorcycle entity);
        void Update(Motorcycle entity);
    }
}
