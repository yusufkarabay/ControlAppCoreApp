using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControlApp.Repository.Migrations
{
    public partial class userpropertyedit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Authorities_AuthorityId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "TC");

            migrationBuilder.AlterColumn<Guid>(
                name: "AuthorityId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "RePassword",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Authorities_AuthorityId",
                table: "Users",
                column: "AuthorityId",
                principalTable: "Authorities",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Authorities_AuthorityId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RePassword",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "TC",
                table: "Users",
                newName: "UserName");

            migrationBuilder.AlterColumn<Guid>(
                name: "AuthorityId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Authorities_AuthorityId",
                table: "Users",
                column: "AuthorityId",
                principalTable: "Authorities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
