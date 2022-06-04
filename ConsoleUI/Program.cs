using Business.Abstracts;
using Business.Concrete;
using DataAccess.concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IBrandService bService = new BrandManager(new EfBrandDal());
            IColorService cService = new ColorManager(new EfColorDal());
            ICarService service = new CarManager(new EfCarDal());
            cService.Add(new Color { ColorId = 1, ColorName = "mavi" });
            bService.Add(new Brand { BrandId = 2, BrandName = "BMW" });
            service.Add(new Car {CarId=5,BrandId=1,ColorId=1,DailyPrice=1500,ModelYear=2020 });
            service.Add(new Car { CarId = 6, BrandId = 2, ColorId = 2, DailyPrice = 1560, ModelYear = 2021 });
            foreach (var detail in service.GetCarDetail())
            {
                Console.WriteLine(detail.BrandName+" / "+detail.ModelYear);
            }

            foreach (var Car in service.GetAll())
            {
                Console.WriteLine(Car.ModelYear);
            }
        }
    }
}
