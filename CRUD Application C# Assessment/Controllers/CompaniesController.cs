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
        public IActionResult CompanyEdit(int id)
        {
            CompaniesModel companiesModel = _companiesRepository.GetCompany(id); //No id specified yet, so throws an error
            //var editModel = new CompaniesModel()
            //{
            //    Id = 1,
            //    Name = "Company Ltd",
            //    Email = "email@email.com",
            //    Logo = "Logo.png",
            //    Website = "www.genericwebsite.com"
            //};
            //return View(editModel);
            if (companiesModel == null)
            {
                System.Diagnostics.Debug.WriteLine("Null!");
            }
            return View(companiesModel);
        }

        [HttpPost]
        public IActionResult CompanyEdit(CompaniesModel companiesModel)
        {
            if (ModelState.IsValid)
            {
                //_companiesRepository.UpdateCompany(companiesModel)
                return RedirectToAction("CompaniesList");
            }
            return View(companiesModel);
        }

        public IActionResult Delete(int? id)
        {
            CompaniesModel companiesModel = _companiesRepository.GetCompany((int)id);
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            //_companiesRepository.deleteCompany(CompaniesModel);
            
            if (ModelState.IsValid)
            {
                //_companiesRepository.Addcompany(companiesModel);
                System.Diagnostics.Debug.WriteLine("Testing"); //This works but needs to be substituted for creating the company
                return RedirectToAction("CompaniesList");
            }
            return null;
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
            if (ModelState.IsValid)
            {
                //_companiesRepository.Addcompany(companiesModel);
                System.Diagnostics.Debug.WriteLine("Testing"); //This works but needs to be substituted for creating the company
                return RedirectToAction("CompaniesList");
            }
            return View(companiesModel);
        }


    }
    //System.Diagnostics.Debug.WriteLine("Testing");
}

