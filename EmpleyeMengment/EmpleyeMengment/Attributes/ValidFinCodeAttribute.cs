using EmpleyeMengment.DataBase;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace EmpleyeMengment.Attributes
{
    public class ValidFinCodeAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            using DataContext dbContexts = new DataContext();
            string finCode = value.ToString();

            if (Regex.IsMatch(finCode, @"^[A-Z0-9]{7}$"))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Some Things is Incorrect Please Check Lenght And Other things (Pls Check letters,letters must be capitalized)");
        }
    }
}
