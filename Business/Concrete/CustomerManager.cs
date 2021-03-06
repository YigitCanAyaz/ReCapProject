using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation.CustomerValidator;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        [SecuredOperation("user, admin")]
        [ValidationAspect(typeof(AddCustomerValidator))]
        [CacheRemoveAspect("ICustomerService.Get")]
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);

            return new SuccessResult(Messages.CustomerAdded);
        }

        [SecuredOperation("user, admin")]
        [ValidationAspect(typeof(DeleteCustomerValidator))]
        [CacheRemoveAspect("ICustomerService.Get")]
        [CacheRemoveAspect("IRentalService.Get")]
        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);

            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CustomersListed);
        }

        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.Id == id), Messages.CustomersListed);
        }

        [SecuredOperation("user, admin")]
        [ValidationAspect(typeof(UpdateCustomerValidator))]
        [CacheRemoveAspect("ICustomerService.Get")]
        [CacheRemoveAspect("IRentalService.Get")]
        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);

            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
