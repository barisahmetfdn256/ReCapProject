﻿using Etities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Etities.Concrate
{
    public class Brand:IEntity
    {
        public int Brandİd { get; set; }
        public string BrandName { get; set; }
    }
}