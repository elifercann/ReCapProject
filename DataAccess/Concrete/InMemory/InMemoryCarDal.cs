using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            //Oracle,Sql Server, Postgres , MongoDb
            _cars = new List<Car> {
                new Car{Id=1, BrandId=1, ModelYear=2019, ColorId=15, DailyPrice=15,Description="lpg gaz"},
                new Car{Id=2, BrandId=1, ModelYear=2010, ColorId=500, DailyPrice=3,Description="otomatik vites"},
                new Car{Id=3, BrandId=2, ModelYear=2011, ColorId=1500, DailyPrice=2,Description="manuel vites"},
                new Car{Id=4, BrandId=2, ModelYear=2009, ColorId=150, DailyPrice=65,Description="lpg gaz"},
                new Car{Id=5, BrandId=2, ModelYear=2013, ColorId=85, DailyPrice=1,Description="otomatik vites,tüplü"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //LINQ - Language Integrated Query
            //Lambda
            Car productToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);

            _cars.Remove(productToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            //Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;

        }

        public List<Car> GetAllById(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();
        }

        public List<Car> GetAllByCategory(int brandId)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
