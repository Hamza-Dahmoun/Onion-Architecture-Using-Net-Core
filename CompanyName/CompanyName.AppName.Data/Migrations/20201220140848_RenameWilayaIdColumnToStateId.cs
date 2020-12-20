using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyName.AppName.Data.Migrations
{
    public partial class RenameWilayaIdColumnToStateId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_State_WilayaId",
                table: "City");

            migrationBuilder.DropIndex(
                name: "IX_City_WilayaId",
                table: "City");

            migrationBuilder.DropColumn(
                name: "WilayaId",
                table: "City");

            migrationBuilder.AddColumn<Guid>(
                name: "StateId",
                table: "City",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_City_StateId",
                table: "City",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_City_State_StateId",
                table: "City",
                column: "StateId",
                principalTable: "State",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_State_StateId",
                table: "City");

            migrationBuilder.DropIndex(
                name: "IX_City_StateId",
                table: "City");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "City");

            migrationBuilder.AddColumn<Guid>(
                name: "WilayaId",
                table: "City",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_City_WilayaId",
                table: "City",
                column: "WilayaId");

            migrationBuilder.AddForeignKey(
                name: "FK_City_State_WilayaId",
                table: "City",
                column: "WilayaId",
                principalTable: "State",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
