using Business.Abstracts;
using DataAccess.Abstracts;
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
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {


            return _carDal.GetAll();
        }

        public List<Car> GetByBrand(int BrandId)
        {
            return _carDal.GetAll(c => c.BrandId == BrandId);
        }

        public Car GetById(int CarId)
        {
            return _carDal.Get(c => c.CarId == CarId);
        }
        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public List<CarDetailDto> GetCarDetail()
        {
             return _carDal.GetCarDetail();
        }
    }
}
