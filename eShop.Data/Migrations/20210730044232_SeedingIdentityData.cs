using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class SeedingIdentityData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("fae6598a-8c21-4ec2-9839-cdc7ea602f19"), "9d396106-bb43-4d8a-bb76-bff5e6b0e841", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("093a6eef-c67f-4590-bc46-fecb419506ae"), 0, "93e73c8a-af2e-4d95-bf19-531133e3192e", new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "khoa028@gmail.com", true, "Dang Van", "Dang Khoa", false, null, "khoa028@gmail.com", "admin", "AQAAAAEAACcQAAAAEJwCzBR/e10so9BsbAKseup4bZEXkO9/01Xu7B3pCN1WAzGSYxxQ8UVRLf+IT2dw7A==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DayCreated",
                value: new DateTime(2021, 7, 30, 11, 42, 31, 88, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("fae6598a-8c21-4ec2-9839-cdc7ea602f19"), new Guid("093a6eef-c67f-4590-bc46-fecb419506ae") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("fae6598a-8c21-4ec2-9839-cdc7ea602f19"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("093a6eef-c67f-4590-bc46-fecb419506ae"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("fae6598a-8c21-4ec2-9839-cdc7ea602f19"), new Guid("093a6eef-c67f-4590-bc46-fecb419506ae") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DayCreated",
                value: new DateTime(2021, 7, 29, 23, 42, 37, 971, DateTimeKind.Local).AddTicks(3029));
        }
    }
}
