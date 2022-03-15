﻿using System.Data.Entity.Migrations;

namespace ProjectPartB.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ProjectPartB.MySchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProjectPartB.MySchoolContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
