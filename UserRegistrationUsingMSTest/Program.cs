using System;

namespace UserRegistrationUsingMSTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            CheckValidOrInvalid obj = new CheckValidOrInvalid();
            Console.WriteLine("enter first name");
            string str1 = Console.ReadLine();
            obj.ValidFirstName(str1);

            Console.WriteLine("enter last name");
            string str2 = Console.ReadLine();
            obj.ValidLastName(str2);


        }
    }
}
