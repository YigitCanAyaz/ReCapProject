using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation.RentalValidator;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        [SecuredOperation("user, admin")]
        [ValidationAspect(typeof(AddRentalValidator))]
        [CacheRemoveAspect("IRentalService.Get")]
        public IResult Add(Rental rental)
        {
            IResult result = BusinessRoles.Run(CheckIfCarHasBeenReturned(rental.CarId));

            if (result != null)
            {
                return result;
            }

            rental.RentDate = DateTime.Now;

            _rentalDal.Add(rental);

            return new SuccessResult(Messages.RentalAdded);

        }

        [SecuredOperation("user, admin")]
        [ValidationAspect(typeof(DeleteRentalValidator))]
        [CacheRemoveAspect("IRentalService.Get")]
        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);

            return new SuccessResult(Messages.RentalDeleted);
        }

        [CacheAspect]
        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalsListed);
        }

        [CacheAspect]
        public IDataResult<List<Rental>> GetAllByCarId(int carId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.CarId == carId), Messages.RentalsListed);
        }

        [CacheAspect]
        public IDataResult<List<Rental>> GetAllByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.CustomerId == customerId), Messages.RentalsListed);
        }

        [CacheAspect]
        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id), Messages.RentalsListed);
        }

        [SecuredOperation("user, admin")]
        [CacheRemoveAspect("IRentalService.Get")]
        public IResult ReturnACar(Rental rental)
        {
            rental.ReturnDate = DateTime.Now;

            Update(rental);

            return new SuccessResult(Messages.RentalCarReturned);
        }

        [SecuredOperation("user, admin")]
        [ValidationAspect(typeof(UpdateRentalValidator))]
        [CacheRemoveAspect("IRentalService.Get")]
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);

            return new SuccessResult(Messages.RentalUpdated);
        }

        private IResult CheckIfCarHasBeenReturned(int carId)
        {
            var result = _rentalDal.GetAll(r => r.CarId == carId);

            foreach (var car in result)
            {
                if (car.ReturnDate == DateTime.MinValue)
                {
                    return new ErrorResult(Messages.CarHasAlreadyBeenRented);
                }
            }

            return new SuccessResult();
        }
    }
}
