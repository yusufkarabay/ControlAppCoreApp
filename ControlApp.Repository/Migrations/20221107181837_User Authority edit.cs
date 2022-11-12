using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControlApp.Repository.Migrations
{
    public partial class UserAuthorityedit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "AuthorityId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Users_AuthorityId",
                table: "Users",
                column: "AuthorityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Authorities_AuthorityId",
                table: "Users",
                column: "AuthorityId",
                principalTable: "Authorities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Authorities_AuthorityId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_AuthorityId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AuthorityId",
                table: "Users");

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
    }
}
