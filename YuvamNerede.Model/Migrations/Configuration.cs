namespace YuvamNerede.Model.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using YuvamNerede.Model.Models.ORM.Entity.SiteEntity;

    internal sealed class Configuration : DbMigrationsConfiguration<YuvamNerede.Model.Models.ORM.DBContext.YuvamNeredeDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(YuvamNerede.Model.Models.ORM.DBContext.YuvamNeredeDBContext context)
        {
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
}
