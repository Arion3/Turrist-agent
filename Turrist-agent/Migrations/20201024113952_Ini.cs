using Microsoft.EntityFrameworkCore.Migrations;

namespace Turrist_agent.Migrations
{
    public partial class Ini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SotrudnikiID",
                table: "Dolzhnosti",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Sotrudniki",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIO = table.Column<string>(nullable: true),
                    Vozrast = table.Column<int>(nullable: false),
                    Pol = table.Column<string>(nullable: true),
                    Adres = table.Column<string>(nullable: true),
                    Telefon = table.Column<int>(nullable: false),
                    Pass_dannie = table.Column<int>(nullable: false),
                    Kod_dolzhnosti = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sotrudniki", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dolzhnosti_SotrudnikiID",
                table: "Dolzhnosti",
                column: "SotrudnikiID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dolzhnosti_Sotrudniki_SotrudnikiID",
                table: "Dolzhnosti",
                column: "SotrudnikiID",
                principalTable: "Sotrudniki",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dolzhnosti_Sotrudniki_SotrudnikiID",
                table: "Dolzhnosti");

            migrationBuilder.DropTable(
                name: "Sotrudniki");

            migrationBuilder.DropIndex(
                name: "IX_Dolzhnosti_SotrudnikiID",
                table: "Dolzhnosti");

            migrationBuilder.DropColumn(
                name: "SotrudnikiID",
                table: "Dolzhnosti");
        }
    }
}
