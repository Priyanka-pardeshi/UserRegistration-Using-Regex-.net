using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class ValidateInput
    {
        public void ValidateName(string firstName)
        {
            string strValidate = "^[A-Z]{1}[A-Za-z]{3,20}";
            if (Regex.IsMatch(firstName, strValidate))
            {
                Console.WriteLine(firstName + " Is Valid First name");
            }
            else
            {
                Console.WriteLine("INVALID");
            }
        }

        public void ValidateEmail(string email)
        {
            string validStrEmail = "^abc.[A-za-z]{3,30}@bl.co(.in|.com)";
            if (Regex.IsMatch(email, validStrEmail))
            {
                Console.WriteLine(email + " is valid Email Id");
            }
            else {
                Console.WriteLine(email+" is Not valid Email");
            }
        }

        public void ValidateNumber(string inputNumber)
        {
            string intEmail = @"^91\s[0-9]{10}";
            if (Regex.IsMatch(inputNumber, intEmail))
            {
                Console.WriteLine(inputNumber + " Number is valid");
            }
            else
            {
                Console.WriteLine(inputNumber+" invalid number");
            }

        }

        public void ValidPassword(string inputPassword)
        {
            string passwordChara = @"[A-Za-z0-9]{8}";
            string passwordOneUpper = @"[A-Z]{1}";

            if (Regex.IsMatch(inputPassword, passwordChara) & Regex.IsMatch(inputPassword, passwordOneUpper))
            {
                Console.WriteLine("This is  valid Password");
            }
            else
            {
                Console.WriteLine("INVALID");
            }

        }
    }
}
