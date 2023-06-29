using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautySalon.Services.Migrations
{
    public partial class AddUserServiceRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserServiceRating",
                columns: table => new
                {
                    UserServiceRatingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserServiceRating", x => x.UserServiceRatingId);
                    table.ForeignKey(
                        name: "FK_UserServiceRating_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "ServiceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserServiceRating_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserServiceRating_ServiceId",
                table: "UserServiceRating",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_UserServiceRating_UserId",
                table: "UserServiceRating",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserServiceRating");
        }
    }
}
