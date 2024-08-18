using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Example3EntityFrameworkLoggingSample.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "State" },
                values: new object[,]
                {
                    { 1, "HttpClient", 1 },
                    { 2, "Aspnet", 1 },
                    { 3, "EntityFramework", 1 },
                    { 4, "WebSockets", 0 },
                    { 5, "gRPC", 0 }
                });

            migrationBuilder.InsertData(
                table: "EventNames",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "RequestPipelineStartDto" },
                    { 2, 1, "RequestPipelineRequestHeaderDto" },
                    { 3, 1, "RequestPipelineEndDto" },
                    { 4, 1, "RequestPipelineResponseHeaderDto" },
                    { 5, 2, "RequestLogDto" },
                    { 6, 2, "RequestBodyDto" },
                    { 7, 2, "ResponseLogDto" },
                    { 8, 2, "ResponseBodyDto" },
                    { 9, 3, "ConnectionOpeningDto" },
                    { 10, 3, "CommandExecutingDto" },
                    { 11, 3, "CommandExecutedDto" }
                });

            migrationBuilder.InsertData(
                table: "EventLogs",
                columns: new[] { "Id", "EventNameId" },
                values: new object[,]
                {
                    { 1, 7 },
                    { 2, 4 },
                    { 3, 3 },
                    { 4, 10 },
                    { 5, 11 },
                    { 6, 1 },
                    { 7, 5 },
                    { 8, 3 },
                    { 9, 9 },
                    { 10, 9 },
                    { 11, 1 },
                    { 12, 2 },
                    { 13, 3 },
                    { 14, 1 },
                    { 15, 3 },
                    { 16, 5 },
                    { 17, 11 },
                    { 18, 1 },
                    { 19, 4 },
                    { 20, 3 },
                    { 21, 2 },
                    { 22, 8 },
                    { 23, 10 },
                    { 24, 6 },
                    { 25, 6 },
                    { 26, 2 },
                    { 27, 11 },
                    { 28, 9 },
                    { 29, 4 },
                    { 30, 6 },
                    { 31, 2 },
                    { 32, 7 },
                    { 33, 8 },
                    { 34, 2 },
                    { 35, 10 },
                    { 36, 9 },
                    { 37, 4 },
                    { 38, 3 },
                    { 39, 6 },
                    { 40, 1 },
                    { 41, 7 },
                    { 42, 2 },
                    { 43, 3 },
                    { 44, 3 },
                    { 45, 2 },
                    { 46, 3 },
                    { 47, 10 },
                    { 48, 8 },
                    { 49, 11 },
                    { 50, 1 },
                    { 51, 4 },
                    { 52, 2 },
                    { 53, 3 },
                    { 54, 4 },
                    { 55, 6 },
                    { 56, 1 },
                    { 57, 10 },
                    { 58, 5 },
                    { 59, 3 },
                    { 60, 6 },
                    { 61, 9 },
                    { 62, 10 },
                    { 63, 8 },
                    { 64, 2 },
                    { 65, 1 },
                    { 66, 7 },
                    { 67, 8 },
                    { 68, 2 },
                    { 69, 5 },
                    { 70, 6 },
                    { 71, 11 },
                    { 72, 6 },
                    { 73, 1 },
                    { 74, 3 },
                    { 75, 1 },
                    { 76, 4 },
                    { 77, 7 },
                    { 78, 3 },
                    { 79, 10 },
                    { 80, 3 },
                    { 81, 9 },
                    { 82, 6 },
                    { 83, 5 },
                    { 84, 3 },
                    { 85, 6 },
                    { 86, 9 },
                    { 87, 11 },
                    { 88, 6 },
                    { 89, 5 },
                    { 90, 4 },
                    { 91, 10 },
                    { 92, 2 },
                    { 93, 5 },
                    { 94, 10 },
                    { 95, 3 },
                    { 96, 3 },
                    { 97, 4 },
                    { 98, 3 },
                    { 99, 4 },
                    { 100, 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "EventLogs",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "EventNames",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EventNames",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EventNames",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EventNames",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EventNames",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EventNames",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EventNames",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EventNames",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EventNames",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EventNames",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EventNames",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
