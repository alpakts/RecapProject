using Core.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.concrete
{
    public class EfCarDal : IEfEntityRepositoryBase<Car, NorthWindContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetail()
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                var result = from C in context.Cars
                             join b in context.Brand
                             on C.ColorId equals b.BrandId
                             select new CarDetailDto
                             {
                                 BrandName = b.BrandName,
                                 BrandId = b.BrandId,
                                 CarId = C.CarId,
                                 ModelYear = C.ModelYear
                             };
                return result.ToList();

            }
        }
    }

}
