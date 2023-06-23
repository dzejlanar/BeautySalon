using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautySalon.Services.Migrations
{
    public partial class AddBaseUserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__BaseUserR__RoleI__29572725",
                table: "BaseUserRole");

            migrationBuilder.DropForeignKey(
                name: "FK__BaseUserR__UserI__2A4B4B5E",
                table: "BaseUserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User_Roles",
                table: "BaseUserRole");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "BaseUserRole",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "RoleID",
                table: "BaseUserRole",
                newName: "RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_BaseUserRole_UserID",
                table: "BaseUserRole",
                newName: "IX_BaseUserRole_UserId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Role",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BaseUserRoleId",
                table: "BaseUserRole",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "BaseUserRole",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaseUserRole",
                table: "BaseUserRole",
                column: "BaseUserRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseUserRole_RoleId",
                table: "BaseUserRole",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseUserRole_BaseUser",
                table: "BaseUserRole",
                column: "UserId",
                principalTable: "BaseUser",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseUserRole_Role",
                table: "BaseUserRole",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "RoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseUserRole_BaseUser",
                table: "BaseUserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseUserRole_Role",
                table: "BaseUserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BaseUserRole",
                table: "BaseUserRole");

            migrationBuilder.DropIndex(
                name: "IX_BaseUserRole_RoleId",
                table: "BaseUserRole");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "BaseUserRoleId",
                table: "BaseUserRole");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "BaseUserRole");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "BaseUserRole",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "BaseUserRole",
                newName: "RoleID");

            migrationBuilder.RenameIndex(
                name: "IX_BaseUserRole_UserId",
                table: "BaseUserRole",
                newName: "IX_BaseUserRole_UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User_Roles",
                table: "BaseUserRole",
                columns: new[] { "RoleID", "UserID" });

            migrationBuilder.AddForeignKey(
                name: "FK__BaseUserR__RoleI__29572725",
                table: "BaseUserRole",
                column: "RoleID",
                principalTable: "Role",
                principalColumn: "RoleID");

            migrationBuilder.AddForeignKey(
                name: "FK__BaseUserR__UserI__2A4B4B5E",
                table: "BaseUserRole",
                column: "UserID",
                principalTable: "BaseUser",
                principalColumn: "UserID");
        }
    }
}
