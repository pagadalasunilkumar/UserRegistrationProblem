using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class UC_5ValidPassword
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
                Console.WriteLine("Invalid password. Password must have a minimum of 8 characters.");
            }
        }

        static bool IsPasswordValid(string password)
        {
            if (password.Length >= 8)
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
