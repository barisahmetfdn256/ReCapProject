using Etities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();

        void Add(Brand entity);

        void Update(Brand entity);

        void Delete(Brand entity);

        List<Brand> GetById(int id);

        List<Brand> GetByBrand(string brand);
    }
}
