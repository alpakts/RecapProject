using Business.Abstracts;
using Core.Utilities.Results;
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

        public IDataResult<List<Car>> GetAll()
        {


            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),"Araçlar listelendi");
        }

        public IDataResult<List<Car>> GetByBrand(int BrandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == BrandId));
        }

        public IResult  GetById(int CarId)
        {
            _carDal.Get(c => c.CarId == CarId);
            return new SuccessResult();
        }
        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult();
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult();
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult();
        }

        public IDataResult<List<CarDetailDto>> GetCarDetail()
        {
              return new SuccessDataResult<List<CarDetailDto>>( _carDal.GetCarDetail(),"Araba detayları getirildi");
        }
    }
}
