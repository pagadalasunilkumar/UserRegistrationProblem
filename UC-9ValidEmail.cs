using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class UC_9ValidEmail
    {
        static void Main()
        {
            string[] emailSamples = {
            "abc.xyz@bl.co.in",
            "john.doe@example.com",
            "test.email@example.co.uk"
            "jane.doe@example.com",
            "invalid.email",
            "another.invalid.email@"
        };

            foreach (string email in emailSamples)
            {
                bool isValidEmail = IsEmailValid(email);

                if (isValidEmail)
                {
                    Console.WriteLine($"Valid email: {email}");
                }
                else
                {
                    Console.WriteLine($"Invalid email: {email}");
                }
            }
        }

        static bool IsEmailValid(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9]+([._%+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+([.-][a-zA-Z0-9]+)*\.[a-zA-Z]{2,}$");
        }
    }
}
