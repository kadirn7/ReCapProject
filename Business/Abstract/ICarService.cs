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
        List<Cars> GetAllByCategoryId(int id);
        List<Cars> GetByUnitPrice(decimal min, decimal max);
    }
}
