using System;
using System.Text.RegularExpressions;

namespace HometownZoo.Core
{
    public static class Validator
    {
        public static bool IsValidUSZipCode(string zip)
        {
            Regex pattern = new Regex(@"^\d{5}-?\d{4}?$");
            //regex could throw a lot of errors so we use the @ to say we want the literal string
            //-? ? means optional 

            return pattern.IsMatch(zip);
        }
    }
}
