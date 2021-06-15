using System;

namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome ");
            ValidateInput objValidate = new ValidateInput();
            objValidate.ValidateFirstName("Siddho");
            Console.ReadKey();
        }
    }
}
