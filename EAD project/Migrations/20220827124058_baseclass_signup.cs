using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EAD_project.Migrations
{
    public partial class baseclass_signup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Creating_date",
                table: "signUp",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Creator",
                table: "signUp",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Modifier",
                table: "signUp",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Modifying_date",
                table: "signUp",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Creating_date",
                table: "signUp");

            migrationBuilder.DropColumn(
                name: "Creator",
                table: "signUp");

            migrationBuilder.DropColumn(
                name: "Modifier",
                table: "signUp");

            migrationBuilder.DropColumn(
                name: "Modifying_date",
                table: "signUp");
        }
    }
}
