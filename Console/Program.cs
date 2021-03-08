using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
 
            CarManager carManager= new CarManager(new InMemoryProductDal());

            foreach (var car in carManager.GetAll()) 
            {
                Console.Writeline(car.BrandId);
            }
        }
    }
}
