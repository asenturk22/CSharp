// See https://aka.ms/new-console-template for more information


using Business.Concrete;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new InMemoryCarDal());

foreach (var car in carManager.GelAll())
{
    Console.WriteLine(car.Description);
}