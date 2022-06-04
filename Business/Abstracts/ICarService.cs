using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IResult GetById(int CarId);
        IResult Add(Car car);
        IResult  Delete(Car car);
        IResult  Update(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetail(); 
    }
}
