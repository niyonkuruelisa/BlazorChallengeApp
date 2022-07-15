using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorChallengeApp.Server.Migrations
{
    public partial class ChangedToGUID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "BookingId1",
                table: "Seat",
                type: "TEXT",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Seat_BookingId1",
                table: "Seat",
                column: "BookingId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_Booking_BookingId1",
                table: "Seat",
                column: "BookingId1",
                principalTable: "Booking",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seat_Booking_BookingId1",
                table: "Seat");

            migrationBuilder.DropIndex(
                name: "IX_Seat_BookingId1",
                table: "Seat");

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

            migrationBuilder.DropColumn(
                name: "BookingId1",
                table: "Seat");

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
    }
}
