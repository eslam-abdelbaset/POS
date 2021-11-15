using FluentMigrator;
using FluentMigrator.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBMigrations.Migrations
{
    [Migration(202104071931)]
    public class _202104071931_SeedingDataToLookup : Migration
    {
        public override void Down()
        {
            //Delete.FromTable("lookUpCategory").Row((new { Name = "CourseType" }));
            //Delete.FromTable("Lookups").Row((new { CategoryId = 1 }));
        }

        public override void Up()
        {
            //Insert.IntoTable("lookUpCategory").Row(new { lookUpCategoryId = 1, lookUpCategoryName = "CourseType" }).WithIdentityInsert();
            //Insert.IntoTable("Lookups").Row(new { Value = "Human Resource", CategoryId = 1 });
            //Insert.IntoTable("Lookups").Row(new { Value = "Project Managment", CategoryId = 1 });
            //Insert.IntoTable("Lookups").Row(new { Value = "Software Development", CategoryId = 1 });
            //Insert.IntoTable("Lookups").Row(new { Value = "Bussiness Adminstration", CategoryId = 1 });
        }
    }
}
