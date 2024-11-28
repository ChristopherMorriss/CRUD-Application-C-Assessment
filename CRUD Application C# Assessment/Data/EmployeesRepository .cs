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
                FirstName = "Johnathan",
                LastName = "Moseph",
                Email = "email@outlook.com",
                Company = "The Power Institute",
                PhoneNumber = "07290 366094"
            },
            new EmployeesModel()
            {
                Id = 1,
                FirstName = "Daniel",
                LastName = "Cumer",
                Email = "daniel@sorkymotors.com",
                Company = "Porkingtons Ltd",
                PhoneNumber = "07554 396033"
            },
            new EmployeesModel()
            {
                Id = 2,
                FirstName = "Sophia",
                LastName = "Twight",
                Email = "sophia@newestate.com",
                Company = "Logo Ltd",
                PhoneNumber = "12346 340908"
                
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
