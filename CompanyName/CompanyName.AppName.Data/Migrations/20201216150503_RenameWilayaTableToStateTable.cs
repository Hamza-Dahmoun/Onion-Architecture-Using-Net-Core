using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyName.AppName.Data.Migrations
{
    public partial class RenameWilayaTableToStateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commune_Wilaya_WilayaId",
                table: "Commune");

            migrationBuilder.DropTable(
                name: "Wilaya");

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Description = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Commune_State_WilayaId",
                table: "Commune",
                column: "WilayaId",
                principalTable: "State",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commune_State_WilayaId",
                table: "Commune");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.CreateTable(
                name: "Wilaya",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wilaya", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Commune_Wilaya_WilayaId",
                table: "Commune",
                column: "WilayaId",
                principalTable: "Wilaya",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
