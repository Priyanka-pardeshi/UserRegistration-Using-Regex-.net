using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration
{
    public class ValidateInput
    {
        public string ValidateName(string firstName)
        {
            string strValidate = "^[A-Z]{1}[A-Za-z]{3,20}";
            if (Regex.IsMatch(firstName, strValidate))
            {
                Console.WriteLine(firstName + " Is Valid First name");
                return firstName;
            }
            else
            {
                Console.WriteLine("INVALID");
                return null;
            }
        }

        public string ValidateEmail(string email)
        {
            string validStrEmail = "^abc.[A-za-z]{3,30}@bl.co(.in|.com)";
            if (Regex.IsMatch(email, validStrEmail))
            {
                Console.WriteLine(email + " is valid Email Id");
                return email;
            }
            else {
                Console.WriteLine(email+" is Not valid Email");
                return null;
            }
        }

        public string ValidateNumber(string inputNumber)
        {
            string intEmail = @"^91\s[0-9]{10}";
            if (Regex.IsMatch(inputNumber, intEmail))
            {
                Console.WriteLine(inputNumber + " Number is valid");
                return inputNumber;
            }
            else
            {
                Console.WriteLine(inputNumber+" invalid number");
                return null;
            }

        }

        public string ValidPassword(string inputPassword)
        {
            string passwordChara = @"[A-Za-z0-9]{8}";
            string passwordOneUpper = @"[A-Z]{1}";
            string passwordOneNumeric = @"[0-9]{1}";
            string passwordSpCharater = @"[><,.!@#$%^&*[(})]{1}";

            if (Regex.IsMatch(inputPassword, passwordChara) & Regex.IsMatch(inputPassword, passwordOneUpper) & Regex.IsMatch(inputPassword,passwordOneNumeric) & Regex.IsMatch(inputPassword,passwordSpCharater))
            {
                Console.WriteLine("This is  valid Password");
                return inputPassword;
            }
            else
            {
                Console.WriteLine("INVALID");
                return null;
            }

        }
    }
}
