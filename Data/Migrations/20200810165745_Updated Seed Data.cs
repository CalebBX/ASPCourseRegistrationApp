using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPCourseRegistrationApp.Data.Migrations
{
    public partial class UpdatedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "StreetAddress", "TwoFactorEnabled", "UserName", "Zipcode" },
                values: new object[,]
                {
                    { "seeduser1", 0, null, "26351442-290a-4c7c-a528-a1158c303a5e", "user1@test.com", true, "John", "Adel", false, null, "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAEAACcQAAAAEMoM5b4xfI1KBhTwy3yr1NXk1/zXyAHL9FWteIJlBIPI3CGXWlN8JqtELrAEKEfzHA==", null, false, "", null, null, false, "user1@test.com", null },
                    { "seeduser2", 0, null, "0dd865ef-bfaf-4164-bd00-277d6f17ef3a", "user2@test.com", true, "Sara", "Rogers", false, null, "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAEAACcQAAAAEA/m3YwLWowtXJUX85YtEaOkHAUzIHoMawl4B+EUXs1FuHQ91UVNQRcWJx1cHLcH7w==", null, false, "", null, null, false, "user2@test.com", null },
                    { "seeduser3", 0, null, "736be620-b3cb-439f-8cb8-009c32113db7", "user3@test.com", true, "Pete", "Smith", false, null, "USER3@TEST.COM", "USER3@TEST.COM", "AQAAAAEAACcQAAAAEB70/k27eHq5eLqorrDFbr55DmBY1dN3mGdunGsvu2MCZzKKmORmEApop7juevI5cg==", null, false, "", null, null, false, "user3@test.com", null },
                    { "seeduser4", 0, null, "baebf98a-6777-4a8c-99a9-b2d6163a88dd", "user4@test.com", true, "Jane", "Write", false, null, "USER4@TEST.COM", "USER4@TEST.COM", "AQAAAAEAACcQAAAAEHjx6cKUBoRjjHsy4jy6iNTF5ctbFS+LrD748YR8pn9SYq2R7aEI5sssO+uua9Pe9A==", null, false, "", null, null, false, "user4@test.com", null }
                });

            migrationBuilder.InsertData(
                table: "FacultyMembers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 102, "Gregory", "House" },
                    { 103, "Heinz", "Doofenshmirtz" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseCode", "CourseName", "EndTime", "InstructorId", "Location", "StartTime" },
                values: new object[,]
                {
                    { 102, "MED502", "Infection Diseases", new DateTime(2020, 8, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), 102, "Apex Building RM130", new DateTime(2020, 8, 10, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 103, "MED120", "Medicine and General Smart-Assery", new DateTime(2020, 8, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), 102, "Apex Building RM130", new DateTime(2020, 8, 10, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 104, "VIL101", "Intro To Villany", new DateTime(2020, 8, 10, 7, 0, 0, 0, DateTimeKind.Unspecified), 103, "Tech Complex RM20", new DateTime(2020, 8, 10, 6, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 105, "VIL203", "Inator-Creation and other Evil Inventions", new DateTime(2020, 8, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), 103, "Tech Complex RM20", new DateTime(2020, 8, 10, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 106, "VIL210", "Advanced Platapus Countermeasures", new DateTime(2020, 8, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), 103, "Tech Complex RM20", new DateTime(2020, 8, 10, 10, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser4");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "FacultyMembers",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "FacultyMembers",
                keyColumn: "Id",
                keyValue: 103);
        }
    }
}
