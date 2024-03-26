using Core.DataAccess.Entity_Framework;
using DataAccess.Abstract;
using DataAccess.DTOs;
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
    public class EfCarDal : EfEntityRepositoryBase<Cars, Rent_A_CarContext>, ICarDal
    {

        public List<CarDetailsDto> GetCarDetails()
        {
            using (Rent_A_CarContext context = new Rent_A_CarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailsDto
                             {
                                 CarName = c.Description,
                                 DailyPrice = c.DailyPrice,
                                 BrandName = b.BrandName,

                             };
                return result.ToList();
            }

        }

    }
}
