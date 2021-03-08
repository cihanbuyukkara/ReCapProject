using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryProductDal()
        {
            _cars = new List<Car> { 
            new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=444200, Description="Liste Fiyatı Vergiler Hariç 208.192 TL ÖTV Oranı % 80", ModelYear=2021},
            new Car{Id=2, BrandId=2, ColorId=1, DailyPrice=2668600, Description="Liste Fiyatı Vergiler Hariç 704.793 TL ÖTV Oranı % 220", ModelYear=2021},
            new Car{Id=3, BrandId=3, ColorId=3, DailyPrice=2979600, Description="Liste Fiyatı Vergiler Hariç 787.156 TL ÖTV Oranı % 220", ModelYear=2021}
            }; 
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete =_cars.SingleOrDefault(c=>c.Id ==car.Id);
         
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
