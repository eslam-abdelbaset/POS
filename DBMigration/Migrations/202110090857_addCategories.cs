using FluentMigrator;
using FluentMigrator.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBMigrations.Migrations
{
    [Migration(202110090857)]
    public class _202110090857_addCategories : Migration
    {
        public override void Down()
        {
            Delete.Table("Categories");
        }

        public override void Up()
        {
            Create.Table("Categories")
                .WithColumn("CategoryId").AsInt32().NotNullable().PrimaryKey().Identity(1, 1)
                .WithColumn("CategoryName").AsString().NotNullable()
                .WithColumn("CategoryCode").AsString().NotNullable()
                .WithColumn("CategoryDescription").AsString(250).Nullable()
                .WithColumn("ParentCategoryId").AsInt32().Nullable()
                .WithColumn("CategoryImagePath").AsString(150).Nullable()
                .WithColumn("IsActive").AsBoolean();
        }
    }
}
