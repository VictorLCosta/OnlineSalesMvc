using System;

namespace OnlineSalesMvc.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message) 
        {
            
        }
    }
}
