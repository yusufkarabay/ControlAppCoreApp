using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControlApp.Repository.Migrations
{
    public partial class UserAuthorityadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Authorities",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Authorities_UserId",
                table: "Authorities",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Authorities_Users_UserId",
                table: "Authorities",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authorities_Users_UserId",
                table: "Authorities");

            migrationBuilder.DropIndex(
                name: "IX_Authorities_UserId",
                table: "Authorities");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Authorities");
        }
    }
}
