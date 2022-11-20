using EmpleyeMengment.Utilities;
using System.ComponentModel.DataAnnotations;

namespace EmpleyeMengment.ViewModels.EmployeViewModel
{
    public class AddViewModel
    {
        [Required]
        [RegularExpression(@"[A-Za-z]{3,20}",ErrorMessage ="Some Things is Incorrect Please Check Lenght and Other things")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z]{3,20}", ErrorMessage = "Some Things is Incorrect Please Check Lenght and Other things")]
        public string Surname { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z]{3,20}", ErrorMessage = "Some Things is Incorrect Please Check Lenght and Other things")]
        public string FatherName { get; set; }

        [Required]
        [ValidFinCodeAttribute]
        public string FinCode { get; set; }

        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
