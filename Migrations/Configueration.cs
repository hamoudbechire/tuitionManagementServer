﻿

namespace SchoolManagementApi.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web; 
    using System.Data.Entity;
    using System.Data.Entity.Migrations; 

    internal sealed class Configuration : DbMigrationsConfiguration<SchoolManagementApi.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SchoolManagementApi.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
