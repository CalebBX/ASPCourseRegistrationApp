using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPCourseRegistrationApp.Data.Migrations
{
    public partial class AddedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FacultyMembers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 100, "Kick", "Buttowski" });

            migrationBuilder.InsertData(
                table: "FacultyMembers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 101, "Ace", "Ventura" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseCode", "CourseName", "EndTime", "InstructorId", "Location", "StartTime" },
                values: new object[] { 100, "DD101", "Intro To Dare-Deviling", new DateTime(2020, 8, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), 100, "Granger Building RM340", new DateTime(2020, 8, 8, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseCode", "CourseName", "EndTime", "InstructorId", "Location", "StartTime" },
                values: new object[] { 101, "CM230", "Advanced Criminology", new DateTime(2020, 8, 8, 9, 0, 0, 0, DateTimeKind.Unspecified), 101, "Apex Building RM110", new DateTime(2020, 8, 8, 8, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "FacultyMembers",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "FacultyMembers",
                keyColumn: "Id",
                keyValue: 101);
        }
    }
}
