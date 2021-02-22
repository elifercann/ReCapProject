using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car Name: " + car.CarName + "\n" + "BrandId: " + car.BrandId + "\n" + "ColorId: " + car.ColorId + "\n" + "Model Year: " + car.ModelYear + "\n" +
                    "\n" + "Car Price: EUR " + car.DailyPrice + "\n" + "Car Stock: " + car.UnitsInStock);

            }
        }
    }
}
