using FluentMigrator;
using FluentMigrator.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBMigrations.Migrations
{
    [Migration(202110090925)]
    public class _202110090925_addCustomersTypes : Migration
    {
        public override void Down()
        {
            Delete.Table("CustomersTypes");
        }

        public override void Up()
        {
            Create.Table("CustomerTypes")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity(1,1)
                .WithColumn("Name").AsString(100).NotNullable()
                .WithColumn("Desciption").AsString(250).Nullable();
        }
    }
}
