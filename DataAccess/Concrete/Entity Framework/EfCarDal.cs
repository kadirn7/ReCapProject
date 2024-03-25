using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Cars entity)
        {
            //IDisposable pattern implementation of c#
            using (Rent_A_CarContext context = new Rent_A_CarContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Cars entity)
        {
            using (Rent_A_CarContext context = new Rent_A_CarContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Cars Get(Expression<Func<Cars, bool>> filter)
        {
            using (Rent_A_CarContext context = new Rent_A_CarContext())
            {
                return context.Set<Cars>().SingleOrDefault(filter);
            }
        }

        public List<Cars> GetAll(Expression<Func<Cars, bool>> filter = null)
        {
            using (Rent_A_CarContext context = new Rent_A_CarContext())
            {
                return filter == null
                    ? context.Set<Cars>().ToList()
                    : context.Set<Cars>().Where(filter).ToList();
            }
        }

        public void Update(Cars entity)
        {
            using (Rent_A_CarContext context = new Rent_A_CarContext())
            {
                var UpdatedEntity = context.Entry(entity);
                UpdatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
