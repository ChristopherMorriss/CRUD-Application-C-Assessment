﻿using CRUD_Application_C__Assessment.Models;
using System.Data.Entity;

namespace CRUD_Application_C__Assessment
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
            Database.SetInitializer(new CreateDatabaseIfNotExists<Context>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<Context>());
        }
        public DbSet<CompaniesModel> Companies { get; set; }
    }
}