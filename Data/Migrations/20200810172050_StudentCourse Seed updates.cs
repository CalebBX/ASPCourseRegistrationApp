using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPCourseRegistrationApp.Data.Migrations
{
    public partial class StudentCourseSeedupdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "9aec89f1-bb11-4ef0-87f1-386ea8c070cd", "AQAAAAEAACcQAAAAEIXGdUJIhLcFwwKxFVLbwbRkz49cQJ/kTrvRVb/t4KfPVVXwWRlpgolUIstL1rwDNA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f9ef1a33-85d7-4b24-b697-d992a2962cdd", "AQAAAAEAACcQAAAAEGKNS8iCO6lIvBhOr21HzGwRdDx862G5l6ZbdSlGPNzdxYd81kGfl/1gow/uPEnHqg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf42f4e2-8ba0-45ef-b16e-74519b3b8309", "AQAAAAEAACcQAAAAEElMvYWGb7l1T8iRi4Gfult4GB2Zu3yzVSzzoQ0ZqGQ3+PvbOiYUBNeEPesKR27SUg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4c9024d9-b188-42ce-852a-44cdf449931b", "AQAAAAEAACcQAAAAEBRlGTX/+RtbIBI1VCBQ78Ha6mel3BQv1dxbeiTtxfNITpPd7q1TRmuZnnzFD16Lig==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2ff1398a-b2b5-48ce-bd0b-ac6c17996a97", "AQAAAAEAACcQAAAAELNevMHMgNnQEFU1J3n7fbqW5O1HNWHiAlr8fnnUcr5rgsjt0VeMlYmX1NeBiFkcXA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7cd494a7-1bbb-49a0-9e57-5eccc03934db", "AQAAAAEAACcQAAAAELU4GY1gtlLlzDaTVr3EsoVDYJ0OKdKATfNRQ2wbUULdwNW4lmpoVc5tiTqBxyno/g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "13b03f54-9913-487c-be34-e2613f2b4b1f", "AQAAAAEAACcQAAAAEOmDujHumf6/HRaI5+RNqaNhR/xeFPwLTw5LjzeH3U+JqwcCgWISY9BAK/A3l/Nk6A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8e22a985-4f5c-452c-9c2d-5a3ee2c3573b", "AQAAAAEAACcQAAAAEMxVp7BG4kvbiVBD7QXCnZiJ3rZs+8AYL5H5d7fiYD8lXxMohnz2K90P5GlSjY9anQ==" });

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
    }
}
