using System;

namespace OnlineSalesMvc.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string message) : base(message) 
        { 
        }
    }
}
