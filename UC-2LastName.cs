using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class UC_2LastName
    {
        static void Main()
        {
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            bool isValidLastName = Regex.IsMatch(lastName, @"^[A-Z][a-zA-Z]{2,}$");

            if (isValidLastName)
            {
                Console.WriteLine("Valid last name.");
            }
            else
            {
                Console.WriteLine("Invalid last name. Last name should start with a capital letter and have at least 3 characters.");
            }
        }
    }
}
