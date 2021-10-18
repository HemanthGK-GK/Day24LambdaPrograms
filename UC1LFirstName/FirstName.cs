using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace UC1LFirstName
{
    public class FirstName
    {
        public string firstname;

        //public FirstName(string name)
        //{
        //    firstname = name;
        //}

        public static bool ValidateFirstName(string Fname) 
        {
            Console.WriteLine("------------------------------------------------------");
            string RegexFirstName = "^[A-Z]{1}[a-z]{2,}$";
           

           var r= Regex.IsMatch(Fname, RegexFirstName);
            //if(Fname.StartsWith(@"[A-Z]"))

            if (Fname.Any(c => char.IsUpper(c)))
            {
                Console.WriteLine("Valid FirstName");
                return true;
            }
            else
            {
                Console.WriteLine("InValid FirstName");
                return false;
            }
           

        }
    }
}
