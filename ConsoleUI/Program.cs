using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
           foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araba Id'si " + car.Id);
                Console.WriteLine("Araba Ücreti " + car.DailyPrice);
            }
            
        }
    }
}