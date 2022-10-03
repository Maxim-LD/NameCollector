using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NameCollector.Migrations.Migrations
{
    public partial class emailAndPhoneNumbeUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "NextOfKinProfile");

            migrationBuilder.DropColumn(
                name: "Message",
                table: "NextOfKinProfile");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "NextOfKinProfile");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "NextOfKinProfile",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "NextOfKinProfile",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "NextOfKinProfile",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProfileId",
                table: "NextOfKinProfile",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "NextOfKinProfile");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "NextOfKinProfile");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "NextOfKinProfile");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "NextOfKinProfile");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "NextOfKinProfile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "NextOfKinProfile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "NextOfKinProfile",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
