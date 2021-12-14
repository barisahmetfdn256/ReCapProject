﻿using Business.Abstract;
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
            return _brandDal.GetALL();
        }

        public List<Brand> GetByBrand(string brand)
        {
            throw new NotImplementedException();
        }


        public List<Brand> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Brand entity)
        {
            _brandDal.Update(entity);
        }
    }
}
