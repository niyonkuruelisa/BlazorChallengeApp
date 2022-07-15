using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorChallengeApp.Server.Migrations
{
    public partial class ChangedSeatTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "BookingId1",
                table: "Seat");

            migrationBuilder.AlterColumn<Guid>(
                name: "BookingId",
                table: "Seat",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "1360f471-00f0-48d8-bbfe-444de705210a", 32.0, "FAMILY X 4(2 AD + 2CH OR 1AD +3 CH)" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "22254ace-3c48-4aa6-9bd7-481f1cfe4c14", 10.0, "ADULT" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "8fb84006-a89d-4e5d-b7dd-6a587e86b366", 8.5, "STUDENT" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "a326aa38-5e26-46ad-94da-9943de234aa1", 8.5, "SENIOR(65 & OVER)" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "c14e06aa-c32b-4da1-b3f0-3b02608c74cc", 10.0, "CHILD (AGE 14 AND UNDER)" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: "1360f471-00f0-48d8-bbfe-444de705210a");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "22254ace-3c48-4aa6-9bd7-481f1cfe4c14");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "8fb84006-a89d-4e5d-b7dd-6a587e86b366");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "a326aa38-5e26-46ad-94da-9943de234aa1");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "c14e06aa-c32b-4da1-b3f0-3b02608c74cc");

            migrationBuilder.AlterColumn<string>(
                name: "BookingId",
                table: "Seat",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BookingId1",
                table: "Seat",
                type: "TEXT",
                nullable: true);

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
    }
}
