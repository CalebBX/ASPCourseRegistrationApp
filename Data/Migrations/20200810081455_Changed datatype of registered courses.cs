using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPCourseRegistrationApp.Data.Migrations
{
    public partial class Changeddatatypeofregisteredcourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2020, 8, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 10, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2020, 8, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 10, 8, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2020, 8, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 9, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2020, 8, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 9, 8, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
