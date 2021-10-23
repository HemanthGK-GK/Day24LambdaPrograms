using System;
using System.Collections.Generic;
using System.Text;

namespace UC13Lambda
{
    class RegistrationException : Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRSTNAME,
            INVALID_LASTNAME,
            INVALID_PASSWORD,
            INVALID_EMAIL_ID,
            INVALID_MOBILE_NUMBER
        }


        ExceptionType type;
        readonly string message;

        public RegistrationException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
            this.message = message;
        }
    }
}
