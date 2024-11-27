

using System.Reflection;

namespace CRUD_Application_C__Assessment.Models
{
    public class CompaniesModel
    {
        public int Id { get; set; }
        public required string Name { get; set; } 
        public  string Email { get; set; }
        public  string Logo { get; set; }
        public  string Website { get; set; }

        public ICollection<EmployeesModel> Employees { get; set; }
    }
}
