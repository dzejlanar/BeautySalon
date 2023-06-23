using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautySalon.Services.Migrations
{
    public partial class UpdateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Appointme__Custo__3A81B327",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK__Appointme__Emplo__3D5E1FD2",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK__Coupon__UserID__403A8C7D",
                table: "Coupon");

            migrationBuilder.DropTable(
                name: "BaseUserRole");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "BaseUser");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_CustomerID",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Appointment");

            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                table: "Appointment",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_EmployeeID",
                table: "Appointment",
                newName: "IX_Appointment_UserID");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AppointmentCount = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__User__1788CCAC974B022B", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.UserRoleId);
                    table.ForeignKey(
                        name: "FK_UserRole_Role",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleID");
                    table.ForeignKey(
                        name: "FK_UserRole_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                table: "UserRole",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK__Appointme__Custo__3A81B327",
                table: "Appointment",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK__Coupon__UserID__403A8C7D",
                table: "Coupon",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Appointme__Custo__3A81B327",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK__Coupon__UserID__403A8C7D",
                table: "Coupon");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Appointment",
                newName: "EmployeeID");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_UserID",
                table: "Appointment",
                newName: "IX_Appointment_EmployeeID");

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "Appointment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BaseUser",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BaseUser__1788CCAC974B022B", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "BaseUserRole",
                columns: table => new
                {
                    BaseUserRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseUserRole", x => x.BaseUserRoleId);
                    table.ForeignKey(
                        name: "FK_BaseUserRole_BaseUser",
                        column: x => x.UserId,
                        principalTable: "BaseUser",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_BaseUserRole_Role",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleID");
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppointmentCount = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Customer__1788CCAC4342F635", x => x.UserID);
                    table.ForeignKey(
                        name: "FK__Customer__UserID__2E1BDC42",
                        column: x => x.UserID,
                        principalTable: "BaseUser",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Employee__1788CCAC7C287117", x => x.UserID);
                    table.ForeignKey(
                        name: "FK__Employee__UserID__30F848ED",
                        column: x => x.UserID,
                        principalTable: "BaseUser",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_CustomerID",
                table: "Appointment",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_BaseUserRole_RoleId",
                table: "BaseUserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseUserRole_UserId",
                table: "BaseUserRole",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK__Appointme__Custo__3A81B327",
                table: "Appointment",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK__Appointme__Emplo__3D5E1FD2",
                table: "Appointment",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK__Coupon__UserID__403A8C7D",
                table: "Coupon",
                column: "UserID",
                principalTable: "BaseUser",
                principalColumn: "UserID");
        }
    }
}
