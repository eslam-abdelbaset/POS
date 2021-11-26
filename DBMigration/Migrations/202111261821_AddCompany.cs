using FluentMigrator;
using FluentMigrator.SqlServer;

namespace DBMigrations.Migrations
{
    [Migration(202111261821)]
    public class _202111261821_AddCompany : Migration
    {
        public override void Down()
        {
            Delete.Table("Company");
        }

        public override void Up()
        {
            Create.Table("Company")
                .WithColumn("CompanyId").AsInt32().NotNullable().PrimaryKey().Identity(1, 1)
                //  .WithColumn("CustomerTypeId").AsInt32().NotNullable()
                .WithColumn("Name").AsString(50).NotNullable()
                .WithColumn("Description").AsString().Nullable()
                .WithColumn("IsActive").AsBoolean();

            //Create.ForeignKey().FromTable("Company").ForeignColumn("CustomerTypeId").ToTable("CustomersTypes").PrimaryColumn("CustomerTypeId");
        }
    }
}
