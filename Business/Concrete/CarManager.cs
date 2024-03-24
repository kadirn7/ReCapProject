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
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Cars> Get(int id)
        {
            return _carDal.GetById(id);
        }

        public List<Cars> GetAll()
        {
            return _carDal.GetAll();    
        }
    }
}
