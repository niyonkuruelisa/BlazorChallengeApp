using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorChallengeApp.Server.Migrations
{
    public partial class MigrationForBookings12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "17313a30-c0ea-4f2e-a338-7fc7a5f165f4");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "51934294-a56e-4f9b-a8b8-62fe4ff3f375");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "703f6e1f-1a4b-4bd7-8f34-6918553a84f1");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "87430d84-aff0-46c3-b879-4c95c74028dd");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "bdf906d1-b4b0-45b1-a6a0-d971108e37e5");

            migrationBuilder.AddColumn<int>(
                name: "CinemaId",
                table: "Booking",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "3b205213-3145-415b-8fc9-b90f010b3d50", 8.5, "STUDENT" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "489f1d68-ef0c-4039-9d91-a809a0d426a1", 10.0, "CHILD (AGE 14 AND UNDER)" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "7ff9590f-831b-43f2-8c1e-fe9a20517920", 32.0, "FAMILY X 4(2 AD + 2CH OR 1AD +3 CH)" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "96b9b790-f67b-4244-ac3a-6cd5932179c1", 10.0, "ADULT" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "b7888c6f-8fb6-440d-b964-29ecef134f38", 8.5, "SENIOR(65 & OVER)" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "3b205213-3145-415b-8fc9-b90f010b3d50");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "489f1d68-ef0c-4039-9d91-a809a0d426a1");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "7ff9590f-831b-43f2-8c1e-fe9a20517920");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "96b9b790-f67b-4244-ac3a-6cd5932179c1");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "b7888c6f-8fb6-440d-b964-29ecef134f38");

            migrationBuilder.DropColumn(
                name: "CinemaId",
                table: "Booking");

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "17313a30-c0ea-4f2e-a338-7fc7a5f165f4", 8.5, "SENIOR(65 & OVER)" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "51934294-a56e-4f9b-a8b8-62fe4ff3f375", 10.0, "ADULT" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "703f6e1f-1a4b-4bd7-8f34-6918553a84f1", 10.0, "CHILD (AGE 14 AND UNDER)" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "87430d84-aff0-46c3-b879-4c95c74028dd", 32.0, "FAMILY X 4(2 AD + 2CH OR 1AD +3 CH)" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "bdf906d1-b4b0-45b1-a6a0-d971108e37e5", 8.5, "STUDENT" });
        }
    }
}
