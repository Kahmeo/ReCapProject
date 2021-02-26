using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;    //Global değişkenleri genelde alt çizgi ile veririz
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
               new Car{Id=1,BrandId=2,ColorId=2,DailyPrice=98000,ModelYear="2005",Description="Sedan"},
               new Car{Id=2,BrandId=2,ColorId=1,DailyPrice=50000,ModelYear="2005",Description="Coupe"},
               new Car{Id=3,BrandId=3,ColorId=3,DailyPrice=198000,ModelYear="2005",Description="Hatchback 3 Kapı"},
               new Car{Id=4,BrandId=4,ColorId=4,DailyPrice=100000,ModelYear="2005",Description="Hatchback 5 Kapı"},
               new Car{Id=5,BrandId=4,ColorId=4,DailyPrice=88000,ModelYear="2005",Description="Station Wagon"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p=>p.Id==car.Id);
            
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
