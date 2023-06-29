using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautySalon.Services.Migrations
{
    public partial class UpdateUserServiceRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserServiceRating_Service_ServiceId",
                table: "UserServiceRating");

            migrationBuilder.DropForeignKey(
                name: "FK_UserServiceRating_User_UserId",
                table: "UserServiceRating");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserServiceRating",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddForeignKey(
                name: "FK_UserServiceRating_Service",
                table: "UserServiceRating",
                column: "ServiceId",
                principalTable: "Service",
                principalColumn: "ServiceID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserServiceRating_User",
                table: "UserServiceRating",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserServiceRating_Service",
                table: "UserServiceRating");

            migrationBuilder.DropForeignKey(
                name: "FK_UserServiceRating_User",
                table: "UserServiceRating");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserServiceRating",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AddForeignKey(
                name: "FK_UserServiceRating_Service_ServiceId",
                table: "UserServiceRating",
                column: "ServiceId",
                principalTable: "Service",
                principalColumn: "ServiceID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserServiceRating_User_UserId",
                table: "UserServiceRating",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
