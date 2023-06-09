using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class UC_1FirstName
    {
        static void Main()
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            bool isValidFirstName = Regex.IsMatch(firstName, @"^[A-Z][a-zA-Z]{2,}$");

            if (isValidFirstName)
            {
                Console.WriteLine("Valid first name.");
            }
            else
            {
                Console.WriteLine("Invalid first name. First name should start with a capital letter and have at least 3 characters.");
            }
        }
    }
}


