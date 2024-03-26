using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.DTOs;
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
        public CarManager(ICarDal productDal)
        {
            _carDal = productDal;
        }

        public IResult Add(Car car)
        {
            ValidateCar(car);

            // Araba ekleme işlemi için özel kurallar burada kontrol edilir

            _carDal.Add(car);

            return new SuccessResult("Ürünler lis"); // Dönüşüm yapılıyor
        }
        private void ValidateCar(Car car)
        {
            
            // Araba ismi minimum 2 karakter olmalı
            if (car.Description.Length < 2)
            {
                throw new ArgumentException("Araba ismi minimum 2 karakter olmalıdır.");
            }

            // Araba günlük fiyatı 0'dan büyük olmalı
            if (car.DailyPrice <= 0)
            {
                throw new ArgumentException("Araba günlük fiyatı 0'dan büyük olmalıdır.");
            }
            //Eğer bu kontrollerden herhangi biri başarısız olursa,
            //bir ArgumentException fırlatılır ve işlem durdurulur.
        }

        public IDataResult<List<Car>> GetAll()
        {

            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<List<Car>> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id));
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(P=>P.DailyPrice>=min && P.DailyPrice<=max));
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
