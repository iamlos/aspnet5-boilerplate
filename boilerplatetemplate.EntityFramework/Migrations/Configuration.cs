using System.Data.Entity.Migrations;
using boilerplatetemplate.Migrations.SeedData;

namespace boilerplatetemplate.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<boilerplatetemplate.EntityFramework.boilerplatetemplateDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "boilerplatetemplate";
        }

        protected override void Seed(boilerplatetemplate.EntityFramework.boilerplatetemplateDbContext context)
        {
            new InitialDataBuilder(context).Build();
        }
    }
}
