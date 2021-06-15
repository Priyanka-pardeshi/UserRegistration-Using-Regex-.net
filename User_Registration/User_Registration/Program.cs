using System;

namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome ");
            ValidateInput objValidate = new ValidateInput();

            Console.WriteLine("Enter First Name to validate:");
            string firstname = Console.ReadLine();
            objValidate.ValidateName(firstname);
            Console.WriteLine("Enter Last Name to validate:");
            string lastName = Console.ReadLine();
            objValidate.ValidateName(lastName);

            Console.ReadKey();
        }
    }
}
