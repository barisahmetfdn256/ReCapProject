using DataAccsess.Abstract;
using Etities.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrate.EntityFramework
{
    public class EfMotorcycleDal : IMotorcycleDal
    {
        public void Add(Motorcycle entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(Motorcycle entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Motorcycle Get(Expression<Func<Motorcycle, bool>> filter)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Motorcycle>().SingleOrDefault();
            }
        }

        public List<Motorcycle> GetALL(Expression<Func<Motorcycle, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return filter == null
                    ? context.Set<Motorcycle>().ToList()
                    : context.Set<Motorcycle>().Where(filter).ToList();

            }
        }

        public void Update(Motorcycle entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
