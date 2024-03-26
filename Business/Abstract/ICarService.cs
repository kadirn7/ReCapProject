using DataAccess.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Cars> GetAll();
        List<Cars> GetAllByBrandId(int id);
        List<Cars> GetByDailyPrice(decimal min, decimal max);
        public void Add(Cars car);
        List<CarDetailsDto> GetCarDetails();

    }
}
