using Business.Abstract;
using DataAccsess.Abstract;
using Etities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void Add(Brand entity)
        {
            _brandDal.Add(entity);
        }

        public void Delete(Brand entity)
        {
            _brandDal.Delete(entity);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public List<Brand> GetByBrand(string brand)
        {
            return _brandDal.GetAll(p=>p.BrandName==brand);
        }

        public List<Brand> GetById(int id)
        {
            return _brandDal.GetAll(p => p.Id == id);
        }

        public void Update(Brand entity)
        {
            _brandDal.Update(entity);
        }
    }
}
