﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal = null;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GelAll()
        {
            // İş kuralları
            return _carDal.GetAll();
        }
    }
}
