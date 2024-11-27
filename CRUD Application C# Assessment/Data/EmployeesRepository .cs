using System.Reflection;
using System.Xml.Linq;
using CRUD_Application_C__Assessment.Models;
namespace CRUD_Application_C__Assessment.Data
{
    public class EmployeesRepository
    {
        private static EmployeesModel[] _employeeModels =
        [
            new EmployeesModel()
            {
                Id = 0,
                FirstName = "Employee Ltd",
                LastName = "Twight",
                Email = "email@email.com",
                Company = "Logo Ltd",
                PhoneNumber = "12908409428"
            },
            new EmployeesModel()
            {
                Id = 0,
                FirstName = "Employee Ltd",
                LastName = "Twight",
                Email = "email@email.com",
                Company = "Logo Ltd",
                PhoneNumber = "12908409428"
            },
            new EmployeesModel()
            {
                Id = 0,
                FirstName = "Employee Ltd",
                LastName = "Twight",
                Email = "email@email.com",
                Company = "Logo Ltd",
                PhoneNumber = "12908409428"
                
            }
        ];

        public EmployeesModel[] GetEmployees()
        {
            return _employeeModels;
        }
        public EmployeesModel GetEmployee(int id)
        {

            EmployeesModel employeeModelInfo = null;
            foreach (var employeeModel in _employeeModels)
            {
                if (employeeModel.Id == id)
                {
                    employeeModelInfo = employeeModel;
                    break;
                }

            }
            return employeeModelInfo;
        }
    }
}
