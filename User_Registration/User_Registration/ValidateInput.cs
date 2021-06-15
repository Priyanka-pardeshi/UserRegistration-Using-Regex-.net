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
    }
}
