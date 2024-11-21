using CRUD_Application_C__Assessment.Data;
using CRUD_Application_C__Assessment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace CRUD_Application_C__Assessment.Controllers
{
    public class CompaniesController : Controller
    {
        private CompaniesRepository _companiesRepository = null;

        public CompaniesController()
        {
            _companiesRepository = new CompaniesRepository();
        }

        public IActionResult CompaniesList(int? id)
        {
            if (id == null)
            {
                Console.WriteLine("Error!");
            }
            var companyModel = _companiesRepository.GetCompany((int)id);
            //{
            //    Name = "Company Ltd",
            //    Email = "email@email.com",
            //    Logo = "Logo.png",
            //    Website = "www.genericwebsite.com"
            //};
            //ViewBag.Name = "Company Ltd";
            //ViewBag.Email = "email@email.com";
            //ViewBag.Logo = "Logo.png";
            //ViewBag.Website = "www.genericwebsite.com";
            //return View(); 
            return View(companyModel);
        }
    }
}
