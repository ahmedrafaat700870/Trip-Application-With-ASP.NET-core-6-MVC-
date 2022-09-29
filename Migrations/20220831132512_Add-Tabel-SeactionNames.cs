using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tourest.Migrations
{
    public partial class AddTabelSeactionNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbSectionNames",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PopuarSeaction = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    SeaSection = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    InstegramSeaction = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    BlogSeaction = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbSectionNames", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbSectionNames");
        }
    }
}
