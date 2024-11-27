

using System.Reflection;

namespace CRUD_Application_C__Assessment.Models
{
    public class CompaniesModel
    {
        public CompaniesModel()
        {
            Employees = new List<EmployeesModel>();
        }

        public int Id { get; set; }
        public required string Name { get; set; } 
        public  string Email { get; set; }
        public byte[] Logo { get; set; }
        public  string Website { get; set; }

        public ICollection<EmployeesModel> Employees { get; set; }
    }
}
