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
            Create.Table("Customers")
                 .WithColumn("CustomerId").AsInt32().NotNullable().PrimaryKey().Identity(1, 1)
                 .WithColumn("CustomerName").AsString().NotNullable()
                 .WithColumn("CustomerPhone").AsString().NotNullable()
                 .WithColumn("CustomerAddress").AsString().NotNullable()
                 .WithColumn("BirthDate").AsDate().Nullable()
                 .WithColumn("CustomerDescription").AsString(250)
                 .WithColumn("CustomerEmail").AsString(50)
                 .WithColumn("CustomerTypeId").AsInt32().NotNullable()
                 .WithColumn("IsActive").AsBoolean().WithDefaultValue(true);
            Create.ForeignKey().FromTable("Customers").ForeignColumn("CustomerTypeId").ToTable("CustomersTypes").PrimaryColumn("CustomerTypeId");
        }
    }
}
