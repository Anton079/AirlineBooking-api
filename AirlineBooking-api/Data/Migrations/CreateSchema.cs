using FluentMigrator;
using System.Data;

namespace AirlineBooking_api.Data.Migrations
{
    [Migration(30052025)]
    public class CreateSchema:Migration
    {
        public override void Up()
        {
            Create.Table("airplaneCompany")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("name").AsString().NotNullable()
                .WithColumn("rating").AsInt32().NotNullable();

            Create.Table("passenger")
                .WithColumn("passengerId").AsInt32().PrimaryKey().Identity()
                .WithColumn("fullName").AsString().NotNullable()
                .WithColumn("phone").AsString().NotNullable()
                .WithColumn("email").AsString().NotNullable()
                .WithColumn("userName").AsString().NotNullable()
                .WithColumn("password").AsString().NotNullable()
                .WithColumn("address").AsString().NotNullable();

            Create.Table("airplane")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("airplaneCompanyId").AsInt32().NotNullable()
                     .ForeignKey("airplaneCompany", "id").OnDelete(Rule.Cascade)
                .WithColumn("modelPlane").AsString().NotNullable()
                .WithColumn("capacity").AsInt32().NotNullable()
                .WithColumn("price").AsInt32().NotNullable();

            Create.Table("ticket")
                .WithColumn("ticketId").AsInt32().PrimaryKey().Identity()
                .WithColumn("airplaneId").AsInt32().NotNullable()
                     .ForeignKey("airplane", "id").OnDelete(Rule.Cascade)
                .WithColumn("passengerId").AsInt32().NotNullable()
                     .ForeignKey("passenger", "passengerId").OnDelete(Rule.Cascade)
                .WithColumn("ticketDate").AsDateTime().NotNullable()
                .WithColumn("ticketDescription").AsString().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("ticket");
            Delete.Table("airplaneCompany");
            Delete.Table("airplane");
            Delete.Table("passenger");
        }
    }
}
