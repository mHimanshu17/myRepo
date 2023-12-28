using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterviewTask.Migrations
{
    public partial class seed_tblUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tbl_users",
                columns: new[] { "UserId", "DOJ", "Department", "EmpCode", "FirstName", "LastLogin", "LastName", "MgrId", "Role", "Seniority", "UserName" },
                values: new object[,]
                {
                    { 105, new DateTime(2018, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accounts", "ACC0034", "Sanjay", new DateTime(2016, 5, 2, 14, 25, 34, 0, DateTimeKind.Unspecified), "Agarwal", 78, "A/C", 5.0800000000000001, "Acc0185" },
                    { 106, new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accounts", "ACC0598", "Amit", null, "Sharma", 105, "Asst.", 8.1500000000000004, "Acc0567" },
                    { 428, new DateTime(2018, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Development", "DEV0833", "Lokesh", new DateTime(2020, 9, 19, 10, 45, 12, 0, DateTimeKind.Unspecified), "Kumar", null, "VP", 1.05, "Dev0476" },
                    { 568, new DateTime(2018, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "ADM0048", "Naresh", null, null, 78, "Exec", 9.0099999999999998, "ADM6633" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_users",
                keyColumn: "UserId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "tbl_users",
                keyColumn: "UserId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "tbl_users",
                keyColumn: "UserId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "tbl_users",
                keyColumn: "UserId",
                keyValue: 568);
        }
    }
}
