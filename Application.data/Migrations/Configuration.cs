namespace Application.data.Migrations
{
    using OldMcDonald.web;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Application.data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Application.data.ApplicationDbContext context)
        {
            Seeder.Seed(context);
        }
    }
}
