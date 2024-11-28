using CRUD_Application_C__Assessment.Models;
namespace CRUD_Application_C__Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Debug.WriteLine("Company.Name");
            using (var context = new Context())
            {
                System.Diagnostics.Debug.WriteLine("Company.Name");
                context.Companies.Add(new CompaniesModel()
                {
                    Name = "Default",
                    //Logo = "Raspberry.png",
                    //Email = "email@email.com"
                });
                context.SaveChanges();
                var companies = context.Companies.ToList();
                foreach (var Company in companies)
                {
                    System.Diagnostics.Debug.WriteLine(Company.Name);
                    Console.WriteLine(Company.Name);
                }
                Console.ReadLine();
            }
        }
    }
}
