using System;
using System.Collections.Generic;
using System.Text;

namespace UC13Lambda
{
    public class RegexPattern
    {
        public const string FirstName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string LastName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string Email = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public const string PhoneNumber = "^[1-9]{1}[0-9]{0,3}\\s[1-9]{1}[0-9]{9}$";
        public const string Password = "^(?=.*[A-Z])(?=.*\\d)[\\S]{8,}$";

        
        public bool ValidateFirstName(string firstName)
        {
            return RegexPattern.Equals(FirstName, FirstName);
        }
        public bool ValidateLastName(string lastName)
        {
            return RegexPattern.Equals(LastName, lastName);
        }
        public bool ValidateEmail(string email)
        {
            return RegexPattern.Equals(Email, email);
        }
        public bool ValidateMobile(string phoneNumber)
        {
            return RegexPattern.Equals(PhoneNumber, phoneNumber);
        }
        public bool ValidatePassword(string password)
        {
            return RegexPattern.Equals(Password, password);
        }
    }
}
