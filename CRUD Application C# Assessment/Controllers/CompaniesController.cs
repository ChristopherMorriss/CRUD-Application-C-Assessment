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

        public IActionResult CompaniesID(int id)   
        {
            
            var companyModel = _companiesRepository.GetCompany(id);
            return View(companyModel); 
        }

        public IActionResult CompaniesList()
        {
            var companies = _companiesRepository.GetCompanies();
            return View(companies);
        }
        public IActionResult CompanyEdit(int id)
        {
            System.Diagnostics.Debug.WriteLine(id);
            CompaniesModel companiesModel = _companiesRepository.GetCompany(id); 
            return View(companiesModel);
        }

        [HttpPost]
        public IActionResult CompanyEdit(CompaniesModel companiesModel)
        {
            System.Diagnostics.Debug.WriteLine(ModelState.IsValid);
            if (ModelState.IsValid) //Currently doesn't work due to logo value
            {
                

                //_companiesRepository.UpdateCompany(companiesModel)
                return RedirectToAction("CompaniesList");
            }
            return RedirectToAction("CompaniesList");
            //return View(companiesModel);
        }

        public IActionResult CompanyDelete(int? id)
        {
            CompaniesModel companiesModel = _companiesRepository.GetCompany((int)id);
            return View();
        }

        [HttpPost]
        public IActionResult CompanyDelete(CompaniesModel companiesModel)
        {
            //_companiesRepository.deleteCompany(CompaniesModel);
            
            if (ModelState.IsValid)
            {
                //_companiesRepository.Addcompany(companiesModel);
                System.Diagnostics.Debug.WriteLine(companiesModel.Id); //This works but needs to be substituted for creating the company
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
                //_companiesRepository.AddCompany(companiesModel);
                //TempData["Message"] = "Your entry was successfully added";
                System.Diagnostics.Debug.WriteLine("Testing"); //This works but needs to be substituted for creating the company
                return RedirectToAction("CompaniesList");
                
            }
            return View(companiesModel);
        }


    }
    //System.Diagnostics.Debug.WriteLine("Testing");
}

