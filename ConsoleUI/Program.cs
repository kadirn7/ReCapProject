﻿using Business.Concrete;
using DataAccess.Concrete.Entity_Framework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName+"/"+car.BrandName+"/"+car.DailyPrice);
            }

        }
    }
}