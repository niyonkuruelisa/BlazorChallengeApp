using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorChallengeApp.Server.Migrations
{
    public partial class ChangedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seat_Booking_BookingId",
                table: "Seat");

            migrationBuilder.DropIndex(
                name: "IX_Seat_BookingId",
                table: "Seat");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "0d745541-5de3-4c0c-9220-b767a395c2d3");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "3e9b2072-2b6a-4048-ab73-50ee17f9aae7");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "435793eb-99b2-4c79-a40c-4949e2fbf9d8");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "6669e586-017f-4bc1-b9b3-c2e997b8292e");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "68dd909a-c406-4aaf-b5f8-5f662e121daa");

            migrationBuilder.AlterColumn<string>(
                name: "BookingId",
                table: "Seat",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "0656a2b3-990d-4009-9d59-d74303252047", 8.5, "STUDENT" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "338e4462-db62-4e75-9ef2-c5ef1402d593", 8.5, "SENIOR(65 & OVER)" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "4b0c1fa1-6018-4f88-beb0-b765b0294baa", 10.0, "CHILD (AGE 14 AND UNDER)" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "c04e6cac-7032-4103-9f7c-972b7579d2d3", 10.0, "ADULT" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "f44c03c9-ce52-40ae-b795-ee032480bd5d", 32.0, "FAMILY X 4(2 AD + 2CH OR 1AD +3 CH)" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "0656a2b3-990d-4009-9d59-d74303252047");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "338e4462-db62-4e75-9ef2-c5ef1402d593");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "4b0c1fa1-6018-4f88-beb0-b765b0294baa");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "c04e6cac-7032-4103-9f7c-972b7579d2d3");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "f44c03c9-ce52-40ae-b795-ee032480bd5d");

            migrationBuilder.AlterColumn<string>(
                name: "BookingId",
                table: "Seat",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "0d745541-5de3-4c0c-9220-b767a395c2d3", 10.0, "ADULT" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "3e9b2072-2b6a-4048-ab73-50ee17f9aae7", 8.5, "SENIOR(65 & OVER)" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "435793eb-99b2-4c79-a40c-4949e2fbf9d8", 10.0, "CHILD (AGE 14 AND UNDER)" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "6669e586-017f-4bc1-b9b3-c2e997b8292e", 8.5, "STUDENT" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "68dd909a-c406-4aaf-b5f8-5f662e121daa", 32.0, "FAMILY X 4(2 AD + 2CH OR 1AD +3 CH)" });

            migrationBuilder.CreateIndex(
                name: "IX_Seat_BookingId",
                table: "Seat",
                column: "BookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_Booking_BookingId",
                table: "Seat",
                column: "BookingId",
                principalTable: "Booking",
                principalColumn: "Id");
        }
    }
}
