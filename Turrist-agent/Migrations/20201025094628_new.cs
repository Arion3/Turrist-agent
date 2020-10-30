using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Turrist_agent.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PutevkiID",
                table: "Sotrudniki",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Dop_uslugi",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naimenovanie = table.Column<string>(nullable: true),
                    Cena = table.Column<int>(nullable: false),
                    Opisanie = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dop_uslugi", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Oteli",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naimenovanie = table.Column<string>(nullable: true),
                    Strana = table.Column<string>(nullable: true),
                    gorod = table.Column<string>(nullable: true),
                    adres = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Kolvo_zvezd = table.Column<int>(nullable: false),
                    kontact_Lico = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oteli", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Putevki",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data_nachala = table.Column<DateTime>(nullable: false),
                    data_okonchaniya = table.Column<DateTime>(nullable: false),
                    prodolzhitelnost = table.Column<int>(nullable: false),
                    kod_vida = table.Column<int>(nullable: false),
                    kod_uslugi_1 = table.Column<int>(nullable: false),
                    kod_uslugi_2 = table.Column<int>(nullable: false),
                    kod_uslugi_3 = table.Column<int>(nullable: false),
                    kod_klienta = table.Column<int>(nullable: false),
                    kod_sotrudnika = table.Column<int>(nullable: false),
                    otmetka_o_broni = table.Column<string>(nullable: true),
                    otmetka_o_oplate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Putevki", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Klienti",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIO = table.Column<string>(nullable: true),
                    Data_rozhdeniya = table.Column<DateTime>(nullable: false),
                    Pol = table.Column<string>(nullable: true),
                    adres = table.Column<string>(nullable: true),
                    telefon = table.Column<string>(nullable: true),
                    pass_dannie = table.Column<string>(nullable: true),
                    PutevkiID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klienti", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Klienti_Putevki_PutevkiID",
                        column: x => x.PutevkiID,
                        principalTable: "Putevki",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Types_of_otdizha",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naimenovanie = table.Column<string>(nullable: true),
                    Ogranicheniya = table.Column<string>(nullable: true),
                    Opisanie = table.Column<string>(nullable: true),
                    PutevkiID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types_of_otdizha", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Types_of_otdizha_Putevki_PutevkiID",
                        column: x => x.PutevkiID,
                        principalTable: "Putevki",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sotrudniki_PutevkiID",
                table: "Sotrudniki",
                column: "PutevkiID");

            migrationBuilder.CreateIndex(
                name: "IX_Klienti_PutevkiID",
                table: "Klienti",
                column: "PutevkiID");

            migrationBuilder.CreateIndex(
                name: "IX_Types_of_otdizha_PutevkiID",
                table: "Types_of_otdizha",
                column: "PutevkiID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sotrudniki_Putevki_PutevkiID",
                table: "Sotrudniki",
                column: "PutevkiID",
                principalTable: "Putevki",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sotrudniki_Putevki_PutevkiID",
                table: "Sotrudniki");

            migrationBuilder.DropTable(
                name: "Dop_uslugi");

            migrationBuilder.DropTable(
                name: "Klienti");

            migrationBuilder.DropTable(
                name: "Oteli");

            migrationBuilder.DropTable(
                name: "Types_of_otdizha");

            migrationBuilder.DropTable(
                name: "Putevki");

            migrationBuilder.DropIndex(
                name: "IX_Sotrudniki_PutevkiID",
                table: "Sotrudniki");

            migrationBuilder.DropColumn(
                name: "PutevkiID",
                table: "Sotrudniki");
        }
    }
}
