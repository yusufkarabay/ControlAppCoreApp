using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControlApp.Repository.Migrations
{
    public partial class sentrydoneuserproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "SentryDones",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_SentryDones_UserId",
                table: "SentryDones",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SentryDones_Users_UserId",
                table: "SentryDones",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SentryDones_Users_UserId",
                table: "SentryDones");

            migrationBuilder.DropIndex(
                name: "IX_SentryDones_UserId",
                table: "SentryDones");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "SentryDones");
        }
    }
}
