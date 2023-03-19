using EMS_Web_Application.Models;
using Microsoft.AspNetCore.Mvc;
using EMS_Web_Application.Repository;
using EMS_Web_Application.Repository.InMemory;
using EMS_Web_Application.Repository.MsSQL;

namespace EMS_Web_Application.Controllers
{
    public class DepartmentController : Controller
    {
        IDeptRepository _deptrepo;

        public DepartmentController(IDeptRepository repo)
        {
            this._deptrepo = repo;
        }
        public IActionResult Department()
        {
            var deptlist = _deptrepo.GetAllDepartments();
            return View(deptlist);
        }

        public IActionResult DeleteDept(int deptId)
        {
            var deptlist = _deptrepo.DeleteDept(deptId);
            return RedirectToAction(controllerName: "Department", actionName: "Department");
        }

        [HttpGet]
        public IActionResult CreateDept()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateDept(DepartmentModel newDept)
        {
            if (ModelState.IsValid)
            {
                var dept = _deptrepo.AddDept(newDept);
                return RedirectToAction("Department");
            }
            ViewData["Message"] = "Data is not valid to create the Department";
            return View();
        }

        [HttpGet]
        public IActionResult UpdateDept(int deptId)
        {
            var oldDept = _deptrepo.GetDeptId(deptId);
            return View(oldDept);
        }
        [HttpPost]
        public IActionResult UpdateDept(DepartmentModel newDept)
        {
            var dept = _deptrepo.UpdateDept(newDept.Id, newDept);
            return RedirectToAction("Department");
        }
        
    }
}
