using System;

namespace Nutritia.Exceptions
{
    public class ApiRequestException : Exception
    {

        public ApiRequestException(string message) : base(message)
        {
            
        }

    }
}
