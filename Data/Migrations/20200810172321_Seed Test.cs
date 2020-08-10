using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPCourseRegistrationApp.Data.Migrations
{
    public partial class SeedTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
