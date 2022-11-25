using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControlApp.Repository.Migrations
{
    public partial class sentrytodoedited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "SentryToDos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_SentryToDos_UserId",
                table: "SentryToDos",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SentryToDos_Users_UserId",
                table: "SentryToDos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SentryToDos_Users_UserId",
                table: "SentryToDos");

            migrationBuilder.DropIndex(
                name: "IX_SentryToDos_UserId",
                table: "SentryToDos");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "SentryToDos");
        }
    }
}
