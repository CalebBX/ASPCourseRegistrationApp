using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPCourseRegistrationApp.Data.Migrations
{
    public partial class SeedDataUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2c73e217-f319-4beb-91af-9bcac66983b0", "AQAAAAEAACcQAAAAEL319PBJy0XMv0Bi3W59e2QTIwkBFqtY82RyVG1VXBFXqzxJtcLOuIqj7tWMnZMlwQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "98850224-3d80-44ae-9316-8cc588e8070a", "AQAAAAEAACcQAAAAENWtx523Yz3RzBgdfUsZxO0/3P4s16weXzINO7FDAcflTxdrky4jvPmlF1ro2F72Fg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af7e4f0a-7ce1-48a2-9356-03fd68cd22d3", "AQAAAAEAACcQAAAAEGsxasj1TvGoeiQL4dY1v0K7CWdbL0CIGkLFUpGShyzLkeJI51yTbi6bFefUEao/8w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f1f99d38-4dac-413b-b1ee-9bd927220471", "AQAAAAEAACcQAAAAECrkMomHkvPk+DfGwGi2eSmxK/Gr422FE/ScdRdh/P4/zVzsWra5NtTiy8tf3ruY9g==" });
        }
    }
}
