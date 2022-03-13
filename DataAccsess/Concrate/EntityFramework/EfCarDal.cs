using DataAccess.Cocrete.EntityFramework;
using DataAccsess.Abstract;
using DataAccsess.Concrate.EntityFramework;
using Etities.Concrate;
using Etities.Concrate.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetail(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from ca in filter is null ? context.Cars : context.Cars.Where(filter)

                             join b in context.Brands
                             on ca.BrandId equals b.Id
                             join co in context.Colors
                             on ca.ColorId equals co.Id

                             select new CarDetailDto
                             {
                                 CarId = ca.Id,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice = ca.DailyPrice,
                                 Model = ca.Model,
                                 ModelYear = ca.ModelYear,
                                 WeeklyPrice = ca.WeeklyPrice,
                                 CarPrice = ca.DailyPrice,
                                 Location = ca.Location,
                                 Description = ca.Description,
                                 Carimg = (from im in context.CarImages
                                            where (ca.Id == im.CarId)
                                            select new Carimg
                                            {
                                                ImagePath = im.ImagePath,
                                                Date = im.Date,
                                                Id = im.Id,
                                                CarId = ca.Id,

                                            }).ToList()
                             };

                return result.ToList();

            };
            }
        }
    }

