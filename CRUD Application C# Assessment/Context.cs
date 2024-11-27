using CRUD_Application_C__Assessment.Models;
using System.Data.Entity;

namespace CRUD_Application_C__Assessment
{
    public class Context : DbContext
    {
        public DbSet<CompaniesModel> Companies { get; set; }
    }
}
