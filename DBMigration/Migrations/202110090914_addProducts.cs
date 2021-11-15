using FluentMigrator;
using FluentMigrator.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBMigrations.Migrations
{
    [Migration(202110090914)]
    public class _202110090914_addProducts : Migration
    {
        public override void Down()
        {
            Delete.Table("Products");
        }

        public override void Up()
        {
            Create.Table("Products")
                .WithColumn("ProductId").AsInt32().NotNullable().PrimaryKey().Identity(1,1)
                .WithColumn("ProductName").AsString(150).NotNullable()
                .WithColumn("ProductCode").AsString(50).NotNullable()
                .WithColumn("ProductDescription").AsString(250).Nullable()
                .WithColumn("ProductPrice").AsFloat().NotNullable()
                .WithColumn("ProductImagePath").AsString(250).Nullable()
                .WithColumn("CategoryId").AsInt32().NotNullable()
                .WithColumn("IsActive").AsBoolean().WithDefaultValue(true);
            Create.ForeignKey().FromTable("Products").ForeignColumn("CategoryId").ToTable("Categories").PrimaryColumn("CategoryId").OnDelete(System.Data.Rule.Cascade);
        }
    }
}
