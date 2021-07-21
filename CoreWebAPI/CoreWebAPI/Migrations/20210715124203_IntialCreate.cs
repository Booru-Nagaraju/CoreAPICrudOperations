using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreWebAPI.Migrations
{
    public partial class IntialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ename = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Emp_ID = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
