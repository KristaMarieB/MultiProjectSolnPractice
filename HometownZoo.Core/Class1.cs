using System;
using System.Text.RegularExpressions;

namespace HometownZoo.Core
{
    /// <summary>
    /// Contains generic validation helper methods
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Validates a given zip code for a US format
        /// </summary>
        /// <param name="zip">The input to check</param>
        /// <returns></returns>
        public static bool IsValidUSZipCode(string zip)
        {
            Regex pattern = new Regex(@"^\d{5}-?\d{4}?$");
            //regex could throw a lot of errors so we use the @ to say we want the literal string
            //-? ? means optional 

            return pattern.IsMatch(zip);
        }
    }
}
