//using CRUD_Application_C__Assessment.Data;
using CRUD_Application_C__Assessment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net;
//using System.Web.Mvc;

namespace CRUD_Application_C__Assessment.Controllers
{
    public class CompaniesController : Controller
    {
        //private CompaniesRepository _companiesRepository;

        //public CompaniesController()
        //{
        //    _companiesRepository = new CompaniesRepository();
        //}

        public IActionResult CompaniesList() //Viewbag works but the transition to model doesn't
        //public IActionResult CompaniesList(int id)   
        {
            System.Diagnostics.Debug.WriteLine("Testing");
            //var companyModel = _companiesRepository.GetCompany(id);
            var companyModel = new CompaniesModel()
            {
                Id = 1,
                Name = "Company Ltd",
                Email = "email@email.com",
                Logo = "Logo.png",
                Website = "www.genericwebsite.com"
            };
            //ViewBag.Name = "Company Ltd";
            //ViewBag.Email = "email@email.com";
            //ViewBag.Logo = "Logo.png";
            //ViewBag.Website = "www.genericwebsite.com";
            //return View();
            //System.Diagnostics.Debug.WriteLine(companyModel.Email); //Evaluates to the correct value
            //System.Diagnostics.Debug.WriteLine(companyModel); //Evaluates to CRUD_Application_C__Assessment.Models.CompaniesModel
            return View(companyModel); //Contains model info here but it disappears when passed to the view
        }

        public IActionResult CompanyEdit(int? id)
        {

            return View();
        }

        public IActionResult Delete(int? id)
        {
            return View();
        }

        public IActionResult CompanyCreate()
        {
            return View();
        }

        [HttpPost]
        //public IActionResult CompanyCreate(string name, string email, string logo, string website)
        public IActionResult CompanyCreate(string name, string email, string logo, string website)
        {

            return View();

        }
    }
}

