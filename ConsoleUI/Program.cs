﻿using Business.Concrete;
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
                Console.WriteLine("Model Yılı :"+car.ModelYear+" Fiyat :"+car.DailyPrice+" Açıklama :"+car.Description);
            }
        }
    }
}
