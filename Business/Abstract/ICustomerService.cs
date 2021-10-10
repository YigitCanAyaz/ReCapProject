﻿using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<Customer> GetById(int id);
        IDataResult<List<Customer>> GetAll();
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);

    }
}
