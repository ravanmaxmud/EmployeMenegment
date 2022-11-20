namespace EmpleyeMengment.ViewModels.EmployeViewModel
{
    public class IndexViewModel
    {
        public string EmployesCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string FinCode { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; } = default;

        public IndexViewModel(string employesCode, string name, string surname, string fatherName, string finCode, string email, bool isDeleted)
        {
            EmployesCode = employesCode;
            Name = name;
            Surname = surname;
            FatherName = fatherName;
            FinCode = finCode;
            Email = email;
            IsDeleted = isDeleted;
        }
    }
}
