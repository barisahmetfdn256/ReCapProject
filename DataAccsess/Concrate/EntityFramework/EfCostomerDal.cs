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
    public class EfCostomerDal : ICostomerDal
    {
        public void Add(Costomer entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(Costomer entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }

        public Costomer Get(Expression<Func<Costomer, bool>> filter)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Costomer>().SingleOrDefault(filter);
            }
        }

        public List<Costomer> GetALL(Expression<Func<Costomer, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return filter == null
                    ? context.Set<Costomer>().ToList()
                    : context.Set<Costomer>().Where(filter).ToList();
            }
        }

        public void Update(Costomer entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
