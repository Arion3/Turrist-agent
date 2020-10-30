using Microsoft.EntityFrameworkCore.Migrations;

namespace Turrist_agent.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dolzhnosti",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Trebovaniya = table.Column<string>(nullable: true),
                    Obyazannosti = table.Column<string>(nullable: true),
                    Oklad = table.Column<int>(nullable: false),
                    Name_dolzhnosti = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dolzhnosti", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dolzhnosti");
        }
    }
}
