using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Cars> GetAll();
        List<Cars> GetById(int id);
        void Add(Cars car);
        void Update(Cars car);
        void Delete(Cars car);
        
    }
}
