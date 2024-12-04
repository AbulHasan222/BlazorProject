using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace UserAppSecurity.Models
{
    public class CustomValidations : ValidationAttribute
    {
        private static readonly Regex EmailRegex = new Regex(
       @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
       RegexOptions.Compiled | RegexOptions.IgnoreCase
   );
        public override bool IsValid(object value)
        {
            var email = value as string;

            if (string.IsNullOrWhiteSpace(email))
            {
                return false; // Email should not be null or empty
            }

            return EmailRegex.IsMatch(email);
        }
    }
}
