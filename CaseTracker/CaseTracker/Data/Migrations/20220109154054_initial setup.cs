using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaseTracker.Data.Migrations
{
    public partial class initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Case",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VslName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VslOffNum = table.Column<int>(type: "int", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    UserFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Case", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Case");
        }
    }
}
