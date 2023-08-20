using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        //FAKE DB
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id = 1, BrandId = 1, ColourId = 1, ModelYear = 2005, DailyPrice = 1000, Description="Hasarsız." },
                new Car {Id = 2, BrandId = 2, ColourId = 3, ModelYear = 2015, DailyPrice = 3000, Description="Sol kapıda hasar var" },
                new Car {Id = 3, BrandId = 1, ColourId = 2, ModelYear = 2018, DailyPrice = 3500, Description="Hasar yok " },
                new Car {Id = 4, BrandId = 4, ColourId = 2, ModelYear = 2019, DailyPrice = 4000, Description="Ön çamurlukta ezik var." },
                new Car {Id = 5, BrandId = 3, ColourId = 1, ModelYear = 2016, DailyPrice = 2750, Description="Hasarsız.  " },
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault( c => c.Id  ==  car.Id);

            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColourId = car.ColourId;
        }
    }
}

/*
 









 */


/*
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 *          _________________   _________________   _____________________
 *          |               |   |               |   |                   |
 *          | InMemoryCarDal|   |               |   |        D          | 
 *          |_______________|   |_______________|   |___________________|
 *                           \           |            / 
 *                            \          |           /
 *                             \         |          /
 *                              \        |         /
 *                        _______\_______|________/__
 *                        |                          |
 *                        |         ICarDal          |
 *                        |__________________________|
 * 
 */