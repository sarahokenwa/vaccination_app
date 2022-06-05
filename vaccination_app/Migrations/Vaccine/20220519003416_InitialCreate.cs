using Microsoft.EntityFrameworkCore.Migrations;

namespace vaccination_app.Migrations.Vaccine
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vaccine",
                columns: table => new
                {
                    Vaccine_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vaccine_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vaccine_Dose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Child_Age = table.Column<int>(type: "int", nullable: false),
                    Disease_Prevention = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ROA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vaccination_Site = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vaccine");
        }
    }
}
