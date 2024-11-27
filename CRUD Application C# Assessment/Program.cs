using CRUD_Application_C__Assessment.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

namespace CRUD_Application_C__Assessment
{
    class Program
    {
        static void Main (string[] args)
        {
            using (var context = new Context())
            {
                context.Companies.Add(new CompaniesModel()
                {
                    Name = "Default",
                    Logo = "Raspberry.png",
                    Email = "email@email.com"
                });
                context.SaveChanges();
                var Companies = context.Companies.ToList();
                foreach(var Company in Companies)
                {
                    System.Diagnostics.Debug.WriteLine(Company.Name);
                    //Console.WriteLine(Company.Name);
                }
                //Console.ReadLine();
            }
        }
    }
}