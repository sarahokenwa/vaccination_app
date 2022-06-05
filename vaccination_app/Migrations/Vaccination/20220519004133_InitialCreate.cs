using Microsoft.EntityFrameworkCore.Migrations;

namespace vaccination_app.Migrations.Vaccination
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vaccination",
                columns: table => new
                {
                    Vaccination_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Child_Id = table.Column<int>(type: "int", nullable: false),
                    Staff_Id = table.Column<int>(type: "int", nullable: false),
                    Vaccine_Id = table.Column<int>(type: "int", nullable: false),
                    Hospital_Id = table.Column<int>(type: "int", nullable: false),
                    ROA = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vaccination");
        }
    }
}
