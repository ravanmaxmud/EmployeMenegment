using EmpleyeMengment.Attributes;
using EmpleyeMengment.Utilities;
using System.ComponentModel.DataAnnotations;

namespace EmpleyeMengment.ViewModels.EmployeViewModel
{
    public class UpdateViewModel
    {
        public string EmployesCode { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z]{3,20}", ErrorMessage = "Some Things is Incorrect Please Check Lenght and Other things")]
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

        public UpdateViewModel()
        {

        }
        public UpdateViewModel(string employecode,string name, string surname, string fatherName, string finCode, string email)
        {
            EmployesCode = employecode;
            Name = name;
            Surname = surname;
            FatherName = fatherName;
            FinCode = finCode;
            Email = email;
        }
    }
}
