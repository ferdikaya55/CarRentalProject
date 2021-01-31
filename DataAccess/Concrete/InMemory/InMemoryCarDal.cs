﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=400,ModelYear=2013,Description="Polo"},
                new Car{Id=2,BrandId=1,ColorId=1,DailyPrice=450,ModelYear=2015,Description="Golf"},
                new Car{Id=3,BrandId=2,ColorId=1,DailyPrice=500,ModelYear=2016,Description="Megane"},
                new Car{Id=4,BrandId=2,ColorId=2,DailyPrice=550,ModelYear=2018,Description="Civic"},
                new Car{Id=5,BrandId=2,ColorId=2,DailyPrice=700,ModelYear=2020,Description="Passat"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetByAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            List<Car> ListedId = _cars.Where(p => p.Id == carId).ToList();
            return ListedId;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
        }
    }
}
