using Microsoft.AspNetCore.Mvc;
using CRUD_Application_C__Assessment.Data;
using CRUD_Application_C__Assessment.Models;
using System.IO;

namespace CRUD_Application_C__Assessment.Controllers
{
    public class EmployeesController : Controller
    {
        private EmployeesRepository _employeesRepository;

        public EmployeesController()
        {
            _employeesRepository = new EmployeesRepository();
        }


        public IActionResult EmployeesID(int id)
        {

            var employeesModel = _employeesRepository.GetEmployee(id);
            return View(employeesModel);
        }

        public IActionResult EmployeesList()
        {
            var employees = _employeesRepository.GetEmployees();
            return View(employees);
        }
        public IActionResult EmployeeEdit(int id)
        {
            EmployeesModel employeesModel = _employeesRepository.GetEmployee(id);
            return View(employeesModel);
        }

        [HttpPost]
        public IActionResult EmployeeEdit(EmployeesModel employeesModel)
        {
            if (ModelState.IsValid)
            {
                //_employeesRepository.UpdateEmployee(employeesModel)
                return RedirectToAction("EmployeesList");
            }
            return View(employeesModel);
        }

        public IActionResult EmployeeDelete(int id) //This one triggers first
        {
            EmployeesModel employeesModel = _employeesRepository.GetEmployee(id);
            return View(employeesModel);
        }

        [HttpPost]
        public IActionResult EmployeeDelete(EmployeesModel employeesModel)
        {
            //_employeesRepository.deleteEmployee(EmployeesModel);
            //var employee = 
            if (ModelState.IsValid)
            {
                //_employeesRepository.Remove(employee);
                System.Diagnostics.Debug.WriteLine(employeesModel.Id); //This works but needs to be substituted for creating the employee
                return RedirectToAction("EmployeesList");
            }
            return null;
        }

        public IActionResult EmployeeCreate()
        {
            var employeesModel = new EmployeesModel() //This is used to display the default values for a new employee
            {
                FirstName="John"
            };
            return View(employeesModel);
        }
        [HttpPost]
        public IActionResult EmployeeCreate(EmployeesModel employeesModel)
        {
            if (ModelState.IsValid)
            {
                
                 EmployeesModel employees = employeesModel.Find(m => m.Id == 1);

                
                //TempData["Message"] = "Your entry was successfully added";
                System.Diagnostics.Debug.WriteLine("Testing"); //This works but needs to be substituted for creating the employee
                return RedirectToAction("EmployeesList");

            }
            return View(employeesModel);
        }
        
        
    }
}
