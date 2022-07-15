using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorChallengeApp.Server.Migrations
{
    public partial class AddedMigration141622 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "4df27a81-219e-400a-82b7-25ffaf7c1a81");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "54fe4bfe-9fb8-44ae-9e10-0e150e748868");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "9f7c45ef-0603-4e90-98ce-a86cc1f2ae0c");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "d82dc5d5-8027-4bc4-ba28-6d9a6a7bf8b9");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "e136d421-5ab0-4277-a3b7-93b1392b9617");

            migrationBuilder.UpdateData(
                table: "Cinema",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Blue Cinema Kigali");

            migrationBuilder.UpdateData(
                table: "Cinema",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Red Olympia Kigali");

            migrationBuilder.UpdateData(
                table: "Cinema",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Yellow Cinema Ireland");

            migrationBuilder.UpdateData(
                table: "Cinema",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Green Olympia France");

            migrationBuilder.UpdateData(
                table: "Cinema",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "White Cinema UK");

            migrationBuilder.UpdateData(
                table: "Cinema",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Black Olympia USA");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Cinema",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Centry Cinema Kigali");

            migrationBuilder.UpdateData(
                table: "Cinema",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Canal Olympia Kigali");

            migrationBuilder.UpdateData(
                table: "Cinema",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Centry Cinema Ireland");

            migrationBuilder.UpdateData(
                table: "Cinema",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Canal Olympia France");

            migrationBuilder.UpdateData(
                table: "Cinema",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Centry Cinema UK");

            migrationBuilder.UpdateData(
                table: "Cinema",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Canal Olympia USA");

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "4df27a81-219e-400a-82b7-25ffaf7c1a81", 8.5, "SENIOR(65 & OVER)" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "54fe4bfe-9fb8-44ae-9e10-0e150e748868", 32.0, "FAMILY X 4(2 AD + 2CH OR 1AD +3 CH)" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "9f7c45ef-0603-4e90-98ce-a86cc1f2ae0c", 8.5, "STUDENT" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "d82dc5d5-8027-4bc4-ba28-6d9a6a7bf8b9", 10.0, "ADULT" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "e136d421-5ab0-4277-a3b7-93b1392b9617", 10.0, "CHILD (AGE 14 AND UNDER)" });
        }
    }
}
