using Microsoft.EntityFrameworkCore.Migrations;

namespace EAD_project.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "login",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_login", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Product",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        oldPrice = table.Column<double>(type: "float", nullable: true),
            //        newPrice = table.Column<double>(type: "float", nullable: true),
            //        Image = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Product", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "signUp",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        userName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_signUp", x => x.Id);
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "login");

            //migrationBuilder.DropTable(
            //    name: "Product");

            //migrationBuilder.DropTable(
            //    name: "signUp");
        }
    }
}
