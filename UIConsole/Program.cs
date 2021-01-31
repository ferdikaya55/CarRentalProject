﻿using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetByAll())
            {
                Console.WriteLine(car.DailyPrice);
            }
        }
    }
}