using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class UC_8SpecialCharacter
    {
        static void Main()
        {
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            bool isValidPassword = IsPasswordValid(password);

            if (isValidPassword)
            {
                Console.WriteLine("Valid password.");
            }
            else
            {
                Console.WriteLine("Invalid password. Password must have a minimum of 8 characters, at least 1 uppercase letter, and at least 1 numeric digit.");
            }
        }

        static bool IsPasswordValid(string password)
        {
            if (password.Length >= 8 && Regex.IsMatch(password, @"[A-Z]") && Regex.IsMatch(password, @"\d"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
