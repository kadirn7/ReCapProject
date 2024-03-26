using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal 
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>() 
            {
            new Car { Id=1,BrandId=1,ColorId=1,DailyPrice=10000,Description="SüperB"},
            new Car { Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 12000, Description = "SüperB" }
        
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car cartoDelete = null;
            cartoDelete=_cars.SingleOrDefault(p=>p.Id==car.Id);

            _cars.Remove(cartoDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(p=>p.Id == carId).ToList();
        }

        

        public void Update(Car car)
        {
            Car carsToUpdate=_cars.SingleOrDefault(p=> p.Id==car.Id);
            carsToUpdate.BrandId = car.BrandId;
            carsToUpdate.ColorId = car.ColorId;
            carsToUpdate.ModelYear = car.ModelYear;
            carsToUpdate.Description = car.Description;
        }

    }
}
