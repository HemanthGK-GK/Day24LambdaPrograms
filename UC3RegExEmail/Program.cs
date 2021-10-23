using System;
using System.Text.RegularExpressions;

namespace UC3RegExEmail
{
    class Program
    {
        class ChkEmail
        {
            public string RegexEmail = "^[a-zA-Z0-9]{2,}[.]+([a-zA-Z0-9]+)*[@][a-zA-Z0-9]{2,}+[.][a-zA-Z]{2,3}+([.][a-zA-Z]{2}+)$";
            public bool Validate(string email)
            {
                return Regex.IsMatch(email, RegexEmail);
            }

        }
        static void Main(string[] args)
        {
            string email;
            bool result;
            ChkEmail obj = new ChkEmail();

            Console.WriteLine("Enter email");
            email = Console.ReadLine();


            result = obj.Validate(email);
            Console.WriteLine(result);
        }
    }
}
