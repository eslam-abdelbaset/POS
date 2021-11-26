using FluentMigrator;
using FluentMigrator.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBMigrations.Migrations
{
    [Migration(202109070239)]
    public class _202109070239_addCustomers : Migration
    {
        public override void Down()
        {
            Delete.Table("Customers");
        }

        public override void Up()
        {
            Create.Table("Customer")
                 .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity(1, 1)
                 .WithColumn("Name").AsString().NotNullable()
                 .WithColumn("Phone").AsString().NotNullable()
                 .WithColumn("Address").AsString().NotNullable()
                 .WithColumn("BirthDate").AsDate().Nullable()
                 .WithColumn("Description").AsString(250)
                 .WithColumn("Email").AsString(50)
                 .WithColumn("TypeId").AsInt32().NotNullable()
                 .WithColumn("IsActive").AsBoolean().WithDefaultValue(true);
            Create.ForeignKey().FromTable("Customer").ForeignColumn("TypeId").ToTable("CustomerTypes").PrimaryColumn("Id");
        }
    }
}
