using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
    public class Result : IResult
    {

        public Result(bool success)
        {
            Success = success;
        }

        public Result(string message, bool success) : this(success)
        {
            Message = message;
        }

        public string Message { get; }

        public bool Success { get; }
    }
}
