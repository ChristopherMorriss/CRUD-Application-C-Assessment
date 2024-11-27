namespace CRUD_Application_C__Assessment.Models
{
    public class EmployeesModel
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
