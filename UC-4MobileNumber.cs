using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class UC_4MobileNumber
    {
        static void Main()
        {
            Console.Write("Enter your mobile number: ");
            string mobileNumber = Console.ReadLine();

            bool isValidMobileNumber = Regex.IsMatch(mobileNumber, @"^\d{2} \d{10}$");

            if (isValidMobileNumber)
            {
                Console.WriteLine("Valid mobile number.");
            }
            else
            {
                Console.WriteLine("Invalid mobile number. Mobile number should be in the format: Country code followed by a space and a 10-digit number.");
            }
        }
    }
}
