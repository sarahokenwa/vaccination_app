using Microsoft.EntityFrameworkCore.Migrations;

namespace vaccination_app.Migrations.Staff
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Staff_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Staff_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Staff_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Staff_Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
