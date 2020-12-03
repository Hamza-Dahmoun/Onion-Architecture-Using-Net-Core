using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyName.AppName.Data.Migrations
{
    public partial class addDossierModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dossier",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    NumDossier = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dossier", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dossier");
        }
    }
}
