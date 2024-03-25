using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService

    {
        ICarDal _carDal;

        public List<Cars> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Cars> GetAllByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cars> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }
    }
}
