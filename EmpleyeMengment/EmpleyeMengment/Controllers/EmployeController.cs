using EmpleyeMengment.DataBase;
using EmpleyeMengment.DataBase.Models;
using EmpleyeMengment.ViewModels.EmployeViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EmpleyeMengment.Controllers
{

    [Route("employe")]
    public class EmployeController : Controller
    {


        #region list
        [HttpGet("Index", Name = "employe-list")]
        public IActionResult Index()
        {   
            using DataContext dbContexts = new DataContext();

            
            var employes =
                dbContexts.Employes.
                Select(e => new IndexViewModel
                (e.EmployesCode, e.Name, e.Surname, e.FatherName, e.FinCode, e.Email, e.IsDeleted)).ToList();
            return View(employes);
            
        }
        #endregion


        #region add

        [HttpGet("Add", Name ="employe-add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("Add", Name ="employe-add")]
        public IActionResult Add(AddViewModel model)
        {
            using DataContext dbContexts = new DataContext();
            if (!ModelState.IsValid) 
            {
                return View(model);
            }

            dbContexts.Employes.Add(new DataBase.Models.Employes { 
                EmployesCode = PkEmpCode.EmployeCode,
                Name = model.Name,
                Surname = model.Surname,
                FatherName = model.FatherName,
                FinCode = model.FinCode,
                Email = model.Email,
                IsDeleted = default

            });
            dbContexts.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        #endregion


        #region del
        [HttpGet("Delete/{employecode}", Name = "employe-soft-del")]
        public IActionResult Delete(string Employecode)
        {
            using DataContext dbContexts = new DataContext();
            var employe = dbContexts.Employes.FirstOrDefault(e => e.EmployesCode == Employecode);
            if (employe is null)
            {
                return NotFound();
            }
             employe.IsDeleted = true;
             dbContexts.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        #endregion


        #region update

        [HttpGet("update/{employecode}", Name = "employe-update-code")]
        public IActionResult Update(string Employecode)
        {
            using DataContext dbContexts = new DataContext();
            var model = dbContexts.Employes.FirstOrDefault(m => m.EmployesCode == Employecode);

            return View(new UpdateViewModel(
                model.EmployesCode,model.Name , model.Surname,model.FatherName,model.FinCode,model.Email));
        }

        [HttpPost("update", Name = "employe-update")]
        public IActionResult Update(UpdateViewModel model)
        {
            using DataContext dbContexts = new DataContext();

            var employe = dbContexts.Employes.FirstOrDefault(e=> e.EmployesCode == model.EmployesCode);
            if (employe is null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            employe.Name = model.Name;
            employe.Surname = model.Surname;
            employe.FatherName = model.FatherName;
            employe.FinCode = model.FinCode;
            employe.Email = model.Email;
            dbContexts.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}
