using CRUD_Application_C__Assessment.Data;
using CRUD_Application_C__Assessment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net;
//using System.Web.Mvc;

namespace CRUD_Application_C__Assessment.Controllers
{
    public class CompaniesController : Controller
    {
        private CompaniesRepository _companiesRepository;

        public CompaniesController()
        {
            _companiesRepository = new CompaniesRepository();
        }

        //public IActionResult CompaniesID() 
        public IActionResult CompaniesID(int id)   
        {
            
            var companyModel = _companiesRepository.GetCompany(id);
            //var companyModel = new CompaniesModel()
            //{
            //    Id = 1,
            //    Name = "Company Ltd",
            //    Email = "email@email.com",
            //    Logo = "Logo.png",
            //    Website = "www.genericwebsite.com"
            //};        
            return View(companyModel); 
        }

        public IActionResult CompaniesList()
        {
            var companies = _companiesRepository.GetCompanies();
            return View(companies);
        }
        public IActionResult CompanyEdit(int? id)
        {
            var editModel = new CompaniesModel()
            {
                Id = 1,
                Name = "Company Ltd",
                Email = "email@email.com",
                Logo = "Logo.png",
                Website = "www.genericwebsite.com"
            };
            return View(editModel);
        }

        public IActionResult Delete(int? id)
        {
            return View();
        }

        public IActionResult CompanyCreate()
        {
            var companiesModel = new CompaniesModel() //This is used to display the default values for a new company
            {
                Name = ""
            };
            return View(companiesModel);
        }
        [HttpPost]
        public IActionResult CompanyCreate(CompaniesModel companiesModel)
        {
            //if (ModelState.isValid)
            //{
            //    _companiesRepository.createCompany(companiesModel)
            //}
            return View(companiesModel);
        }

        //[HttpPost]
        //public IActionResult CompanyCreate(string name, string email, string logo, string website)
        //{
            
        //    return View();

        //}
    }
    //System.Diagnostics.Debug.WriteLine("Testing");
}

