using EMS_Web_Application.Models;
using Microsoft.AspNetCore.Mvc;
using EMS_Web_Application.Repository;
using EMS_Web_Application.Repository.InMemory;
using EMS_Web_Application.Repository.MsSQL;


namespace EMS_Web_Application.Controllers
{
    public class EmployeeController : Controller
    {
        IEmpRepository _emprepo;

        public EmployeeController(IEmpRepository repo)
        {
            this._emprepo = repo;
        }
        public IActionResult Employee()
        {
            var emplist = _emprepo.GetAllEmployees();
            return View(emplist);
        }

        public IActionResult Details(int empId)
        {
            var emp = _emprepo.GetEmpId(empId);
            return View(emp);
        }

        public IActionResult DeleteEmp(int empId)
        {
            var emplist = _emprepo.DeleteEmp(empId);
            return RedirectToAction(controllerName: "Employee", actionName: "Employee");
        }

        [HttpGet]
        public IActionResult CreateEmp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEmp(EmployeeModel newEmp) 
        {
            if (ModelState.IsValid)
            {
                var emp = _emprepo.AddEmp(newEmp);
                return RedirectToAction("Employee");
            }
            ViewData["Message"] = "Data is not valid to create the Employee";
            return View();
        }
        [HttpGet]
        public IActionResult UpdateEmp(int empId)
        {
            var oldEmp = _emprepo.GetEmpId(empId);
            return View(oldEmp);
        }
        [HttpPost]
        public IActionResult UpdateEmp(EmployeeModel newEmp)
        {
            var emp = _emprepo.UpdateEmp(newEmp.Id, newEmp);
            return RedirectToAction("Employee");
        }
    }
}
