using System;
using System.Text.RegularExpressions;

namespace UC2RegExLastName
{
    class Program
    {
        class ChkLastName
        {
            public string RegexLastName = "^[A-Z]{1}[a-z]{2,}$";
            public bool Validate(string lastname)
            {
                return Regex.IsMatch(lastname, RegexLastName);
            }

        }
        static void Main(string[] args)
        {
            string lastName;
            bool result;
            ChkLastName obj = new ChkLastName();

            Console.WriteLine("Enter LastName");
            lastName = Console.ReadLine();


            result = obj.Validate(lastName);
            Console.WriteLine(result);
        }
    }
}
