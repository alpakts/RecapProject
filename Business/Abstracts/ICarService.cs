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
        List<Car> GetAll();
        Car GetById(int CarId);
        public void Add(Car car);
        public void Delete(Car car);
        public void Update(Car car);
        public List<CarDetailDto> GetCarDetail(); 
    }
}
