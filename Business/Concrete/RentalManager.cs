using Business.Abstracts;
using Business.Constants;
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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentdal;

        public RentalManager(IRentalDal rentdal)
        {
            _rentdal = rentdal;
        }

        public IResult Add(Rental rental)
        {
            if (rental.RentDate > DateTime.Now)
            {
                _rentdal.Add(rental);
                return new SuccessResult(Messages.Added);
                


            }
            else
            {
                return new ErrorResult(Messages.RentError);
            }
            
        }

        public IResult Delete(Rental rental)
        {
            _rentdal.Delete(rental);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentdal.GetAll(), Messages.Listed);
        }

        public IResult Update(Rental rental)
        {
            return new SuccessResult(Messages.Updated);
        }
    }
}
