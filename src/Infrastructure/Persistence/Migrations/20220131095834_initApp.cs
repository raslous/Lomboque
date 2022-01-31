using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lomboque.Infrastructure.Persistence.Migrations
{
    public partial class initApp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LarikObservasi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tanggal = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Jam = table.Column<TimeOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LarikObservasi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SuhuUdara = table.Column<float>(type: "REAL", nullable: false),
                    KelembabanTanah = table.Column<int>(type: "INTEGER", nullable: false),
                    ObservasiId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pot", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pot_LarikObservasi_ObservasiId",
                        column: x => x.ObservasiId,
                        principalTable: "LarikObservasi",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pot_ObservasiId",
                table: "Pot",
                column: "ObservasiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pot");

            migrationBuilder.DropTable(
                name: "LarikObservasi");
        }
    }
}
