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
                name: "Observasi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomorPot = table.Column<int>(type: "INTEGER", nullable: false),
                    SuhuUdara = table.Column<float>(type: "REAL", nullable: false),
                    KelembabanTanah = table.Column<int>(type: "INTEGER", nullable: false),
                    Tanggal = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Jam = table.Column<TimeOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Observasi", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Observasi");
        }
    }
}
