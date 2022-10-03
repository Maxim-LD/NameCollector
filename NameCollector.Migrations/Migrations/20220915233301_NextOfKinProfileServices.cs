using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NameCollector.Migrations.Migrations
{
    public partial class NextOfKinProfileServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NextOfKinProfile",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    Relationship = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                 
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NextOfKinProfile", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NextOfKinProfile");
        }
    }
}
