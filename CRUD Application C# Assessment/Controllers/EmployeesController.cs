using Microsoft.AspNetCore.Mvc;

namespace CRUD_Application_C__Assessment.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult EmployeesList()
        {
            ViewBag.First_name = "Johnathan";
            ViewBag.Last_name = "Example";
            ViewBag.Company = "Company Limited";
            ViewBag.Email = "email@email.com";
            ViewBag.Phone_number = "010101010";
            return View();
        }
        
    }
}
