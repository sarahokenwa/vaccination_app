using Microsoft.EntityFrameworkCore.Migrations;

namespace vaccination_app.Migrations.Mother
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mother",
                columns: table => new
                {
                    Mother_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Child_Id = table.Column<int>(type: "int", nullable: false),
                    Mother_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mother_Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mother");
        }
    }
}
