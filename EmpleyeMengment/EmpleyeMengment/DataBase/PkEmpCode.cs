using EmpleyeMengment.DataBase.Models;
using EmpleyeMengment.ViewModels.EmployeViewModel;
using Microsoft.Extensions.FileProviders;

namespace EmpleyeMengment.DataBase
{
    public class PkEmpCode
    {
		static Random _random = new Random();
		private static string _employeCode;

		public static string EmployeCode
		{
			get 
			{
				DataContext dataContext = new DataContext();
				var employees = dataContext.Employes.ToList();

				bool go = true;
				string newCode = "E" + _random.Next(10000, 100000);

				while (go)
				{
					int lastCode = 0;

					foreach (var employe in employees)
					{
						if (employe.EmployesCode == newCode)
						{
                            do
                            {
                                newCode = "E" + _random.Next(10000, 100000);

                            } while (employe.EmployesCode != newCode);
                        }
						lastCode++;

					}
					if (lastCode == employees.Count)
					{
						go = false;
					}
				}
				return newCode;
			}
		}

	}
}
