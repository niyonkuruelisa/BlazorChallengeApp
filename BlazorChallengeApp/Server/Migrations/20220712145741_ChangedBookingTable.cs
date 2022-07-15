using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorChallengeApp.Server.Migrations
{
    public partial class ChangedBookingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "054082f3-5a14-4434-8370-6e39533a0245");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "0e5be183-21e7-480c-81a8-2cd1aa085fda");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "25f2b95b-5b5d-4458-8e1f-3c8c1623a47f");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "4f8c1c2b-9c0e-48e9-a6f5-4d4a7f082f13");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "50bdfc3f-c240-4e44-b668-1ade98e10c06");

            migrationBuilder.AlterColumn<string>(
                name: "day",
                table: "Booking",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "366a0084-788c-4e11-9057-049955723f18", 10.0, "CHILD (AGE 14 AND UNDER)" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "3d0dfba7-9def-49be-adbe-b15baa2e042e", 32.0, "FAMILY X 4(2 AD + 2CH OR 1AD +3 CH)" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "775efb2a-c33e-46a8-9ef1-64ba87d6b2d6", 8.5, "SENIOR(65 & OVER)" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "a4b9d020-9696-4130-a5d8-8f36ba8aabdf", 8.5, "STUDENT" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "f660b131-7c0a-47cd-834b-c3c374ca00e2", 10.0, "ADULT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "366a0084-788c-4e11-9057-049955723f18");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "3d0dfba7-9def-49be-adbe-b15baa2e042e");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "775efb2a-c33e-46a8-9ef1-64ba87d6b2d6");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "a4b9d020-9696-4130-a5d8-8f36ba8aabdf");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "f660b131-7c0a-47cd-834b-c3c374ca00e2");

            migrationBuilder.AlterColumn<string>(
                name: "day",
                table: "Booking",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "054082f3-5a14-4434-8370-6e39533a0245", 8.5, "SENIOR(65 & OVER)" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "0e5be183-21e7-480c-81a8-2cd1aa085fda", 32.0, "FAMILY X 4(2 AD + 2CH OR 1AD +3 CH)" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "25f2b95b-5b5d-4458-8e1f-3c8c1623a47f", 10.0, "ADULT" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "4f8c1c2b-9c0e-48e9-a6f5-4d4a7f082f13", 10.0, "CHILD (AGE 14 AND UNDER)" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "50bdfc3f-c240-4e44-b668-1ade98e10c06", 8.5, "STUDENT" });
        }
    }
}
