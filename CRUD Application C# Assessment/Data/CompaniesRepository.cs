using System;
using System.Reflection;
using System.Xml.Linq;
using CRUD_Application_C__Assessment.Models;
namespace CRUD_Application_C__Assessment.Data
{
    public class CompaniesRepository
    {
        private static CompaniesModel[] _companyModels =
        [
            new CompaniesModel()
            {
                Id = 0,
                Name = "Company Ltd",
                Email = "email@email.com",
                Logo = null,
                Website = "www.genericwebsite.com"
            },
            new CompaniesModel()
            {
                Id = 1,
                Name = "Workplace Ltd",
                Email = "email@gmail.com",
                Logo = null,
                Website = "www.genericwebsite.co.uk"
            },
            new CompaniesModel()
            {
                Id = 2,
                Name = "Job Ltd",
                Email = "email@seamail.com",
                Logo = null,
                Website = "www.genericwebsite.net"
            }
        ];

        public CompaniesModel[] GetCompanies()
        {
            return _companyModels;
        }
        public CompaniesModel GetCompany(int id)
        {

            CompaniesModel companyModelInfo = null;
            foreach (var companyModel in _companyModels)
            {
                if (companyModel.Id == id)
                {
                    companyModelInfo = companyModel;
                    break;
                }
               
            }
            return companyModelInfo;
        }

        
    }
}
