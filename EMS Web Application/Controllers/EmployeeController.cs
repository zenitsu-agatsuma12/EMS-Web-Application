﻿using EMS_Web_Application.Models;
using Microsoft.AspNetCore.Mvc;
using EMS_Web_Application.Repository;
using EMS_Web_Application.Repository.InMemory;
using EMS_Web_Application.Repository.MsSQL;
using Microsoft.AspNetCore.Mvc.ModelBinding;

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
        public IActionResult CreateEmp(EmployeeViewModel viewModel) 
        {
            if (ModelState.IsValid)
            {
                var newEmp = new Employee(viewModel.Id, viewModel.Name, viewModel.DOB, viewModel.Email, viewModel.Phone, viewModel.DepartmentId);
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
            var viewModel = new EmployeeViewModel(oldEmp.Id, oldEmp.Name, oldEmp.DOB, oldEmp.Email, oldEmp.Phone, oldEmp.DepartmentId);
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult UpdateEmp(EmployeeViewModel viewModel)
        {
            if (ModelState.IsValid) { 
            var newEmp = new Employee(viewModel.Id, viewModel.Name, viewModel.DOB, viewModel.Email, viewModel.Phone, viewModel.DepartmentId);
            var emp = _emprepo.UpdateEmp(newEmp.Id, newEmp);
            return RedirectToAction("Employee");
            }
            return View();
        }
    }
}
