namespace ElectronicManager.Web.Migrations
{
    using Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ElectronicManager.Web.Infrastructure.DepartmentDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ElectronicManager.Web.Infrastructure.DepartmentDb context)
        {
            context.Departments.AddOrUpdate(d => d.Name,
                new Department() { Name = "Engineering" },
                new Department() { Name = "Sales" },
                new Department() { Name = "Shipping" },
                new Department() { Name = "Human Resources" }
            );
        }


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        
    }
}
