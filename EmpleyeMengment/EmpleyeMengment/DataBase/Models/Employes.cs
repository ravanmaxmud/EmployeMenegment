namespace EmpleyeMengment.DataBase.Models
{
    public class Employes
    {
        public int Id { get; set; }
        public string EmployesCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string FinCode { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; } = default;

    }
}
