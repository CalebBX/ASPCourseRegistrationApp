using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPCourseRegistrationApp.Data.Migrations
{
    public partial class Addedseeddataforstudentcourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "36b46904-28cd-45ce-82de-e0d1c2227df8", "AQAAAAEAACcQAAAAEDTcmc+KKaYiCrPFXUjhrvhy1dQGvDFxUTeUE7T1rqUY6Q9v/BrF5iupMaRvel5LiA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "59729677-b395-46c8-bdd6-0b861178af68", "AQAAAAEAACcQAAAAELfZv24D46216YSwRLb6Z3hJlzU+VgK9m0Xpl1SSaVuE0YXpvb394xa66Z2fry2IyQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "526ec172-d94f-4dd4-a2c4-0ea17734ff71", "AQAAAAEAACcQAAAAEJQc4lx0H6tfm50WXfUsBGGZEKrpIZgyBFdFgbmxLogMm7WUUlOOTRH2T3cupITOYw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeduser4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bef6e50d-d087-4f92-bf8c-b233a509b5ab", "AQAAAAEAACcQAAAAEFynZSGIlG/mADatk4G7Dw4gIqv9G9XYHylQt6IUa05lyezHxzFGP3wA3UPWVkn1Bg==" });
        }
    }
}
