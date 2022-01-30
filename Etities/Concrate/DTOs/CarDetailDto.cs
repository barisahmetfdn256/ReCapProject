using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Etities.Concrate.DTOs
{
    public class CarDetailDto:IDto
    {
        public int CarId { get; set; }
        public string Model { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int DailyPrice { get; set; }
        public int? WeeklyPrice { get; set; }
        public int? CarPrice { get; set; }
        public int ModelYear { get; set; }
    }
}
