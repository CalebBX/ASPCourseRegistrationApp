using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPCourseRegistrationApp.Data.Migrations
{
    public partial class Readdedstudentcourseseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a10e73f1-f583-48da-a921-9424bbc6b11d", "AQAAAAEAACcQAAAAEEVpCCzkt+1GZ2ihTEsyHoCLHk3J+nGCNTA2i9YVc9GBDPXJJRNK3pkTf67sQphdPA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac9ddab5-7f86-49d6-8129-22e87e42a53b", "AQAAAAEAACcQAAAAEDAhn+JmgAEUdaRdjFRivvRWmPppbMRr/vmWUAas/xDi++wCdI4Z7IJQ5h/UAjzpDA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4802aed5-7eed-4259-aacc-6f47deb6ecb2", "AQAAAAEAACcQAAAAEHWVZfuYFT3tjeFXmnMJxVjWvsfJ593w96p+XeoA6WX5hiA+kHyVXHUu7AYM508Acg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cff377d7-fa3a-45b3-aea9-a990d35ab8c6", "AQAAAAEAACcQAAAAEEcPPJHeAIK1FkWAlwJ/GlGiCwxbHuQVrIjiAXtCFNKwmuxztL8/QKM+AGoDzHwPpg==" });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "StudentId", "CourseId" },
                values: new object[,]
                {
                    { "seeduser1", 103 },
                    { "seeduser1", 100 },
                    { "seeduser1", 104 },
                    { "seeduser2", 104 },
                    { "seeduser2", 105 },
                    { "seeduser2", 106 },
                    { "seeduser3", 104 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "StudentId", "CourseId" },
                keyValues: new object[] { "seeduser1", 100 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "StudentId", "CourseId" },
                keyValues: new object[] { "seeduser1", 103 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "StudentId", "CourseId" },
                keyValues: new object[] { "seeduser1", 104 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "StudentId", "CourseId" },
                keyValues: new object[] { "seeduser2", 104 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "StudentId", "CourseId" },
                keyValues: new object[] { "seeduser2", 105 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "StudentId", "CourseId" },
                keyValues: new object[] { "seeduser2", 106 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "StudentId", "CourseId" },
                keyValues: new object[] { "seeduser3", 104 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "545545ea-325c-49fd-a5f8-182816941851", "AQAAAAEAACcQAAAAEDlU8JtkiDB/WJIhY3PUlnSHfjco0B5JykJ3neO5ijeOjbTWR1fAPmeh3PEnQSp4Yw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "de43d838-8770-47bb-a996-fc2f6220e7f8", "AQAAAAEAACcQAAAAEKJ4sHdB7kM5gFqKjdY9el1gDIYpZ6pLXP7gVPaBiCkNN/kcULao6nORQgnYwKhhHg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ff4294d-bf1f-4679-a4ba-8f0000c8ed54", "AQAAAAEAACcQAAAAEEKblsI4E5gI0o+AiCbWi3I3mZEMbFsUyyZ1HzayknBg3FACUrEpnpQgJkf/5Ok+UA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bfa33787-dd78-4e8f-9dab-ee192f630eea", "AQAAAAEAACcQAAAAENudPW6ZDC4NlfUmhHS5IG6NkeOsuPAhkuEwmaukQkrIa8zlD1QmdzRlxquYo3Ol+Q==" });
        }
    }
}
