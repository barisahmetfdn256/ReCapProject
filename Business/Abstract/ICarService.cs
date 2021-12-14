﻿using Etities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();

        void Add(Car entity);

        void Update(Car entity);

        void Delete(Car entity);

        List<Car> GetById(int id);

        List<Car> GetByColor(string color);
    }
}
