using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorChallengeApp.Server.Migrations
{
    public partial class AddedMigration141522 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "3416a481-2f1c-40d0-a50a-88de111b09e2");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "471aa112-1b84-4d48-8c9c-3479b531d587");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "a3d15b31-dcd7-4149-a484-35020b5e449f");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "e961848d-d94c-4a2a-8e39-876ffcabef74");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "ea848253-e9be-4c1f-9f03-c511ff2ba806");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "3416a481-2f1c-40d0-a50a-88de111b09e2", 8.5, "STUDENT" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "471aa112-1b84-4d48-8c9c-3479b531d587", 10.0, "CHILD (AGE 14 AND UNDER)" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "a3d15b31-dcd7-4149-a484-35020b5e449f", 8.5, "SENIOR(65 & OVER)" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "e961848d-d94c-4a2a-8e39-876ffcabef74", 10.0, "ADULT" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "ea848253-e9be-4c1f-9f03-c511ff2ba806", 32.0, "FAMILY X 4(2 AD + 2CH OR 1AD +3 CH)" });
        }
    }
}
