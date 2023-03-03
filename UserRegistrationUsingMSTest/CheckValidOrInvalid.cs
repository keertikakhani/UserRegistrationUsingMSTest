using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUsingMSTest
{
    public class CheckValidOrInvalid
    {
        // First Name
        public bool ValidFirstName(string firstName)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            if (Regex.IsMatch(firstName, pattern))
            {
                Console.WriteLine("{0} is valid", firstName);
                return true;
            }
            else
            {
                Console.WriteLine("{0} is not valid", firstName);
                return false;
            }
        }
        // Last Name
        public bool ValidLastName(string Lastname)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            if (Regex.IsMatch(Lastname, pattern))
            {
                Console.WriteLine("{0} is valid", Lastname);
                return true;
            }
            else
            {
                Console.WriteLine("{0} is not valid", Lastname);
                return false;
            }
        }
    }
}
