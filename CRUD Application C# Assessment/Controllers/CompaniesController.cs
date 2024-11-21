using Microsoft.AspNetCore.Mvc;

namespace CRUD_Application_C__Assessment.Controllers
{
    public class CompaniesController : Controller
    {



        public IActionResult CompaniesList()
        {
            //var Company = new Company()
            //{
            //    Name = "Company Ltd";
            //    Email = "email@email.com";
            //    Logo = "Logo.png";
            //    Website = "www.genericwebsite.com";
            //}
            ViewBag.Name = "Company Ltd";
            ViewBag.Email = "email@email.com";
            ViewBag.Logo = "Logo.png";
            ViewBag.Website = "www.genericwebsite.com";
            return View(); 
            //return View(Company);
        }
    }
}
