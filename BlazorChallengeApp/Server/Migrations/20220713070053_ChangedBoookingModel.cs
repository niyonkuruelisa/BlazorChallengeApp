using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorChallengeApp.Server.Migrations
{
    public partial class ChangedBoookingModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "time",
                table: "Booking",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "movieId",
                table: "Booking",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "day",
                table: "Booking",
                newName: "Day");

            migrationBuilder.AlterColumn<string>(
                name: "Time",
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
                values: new object[] { "0c6614ba-f633-4462-a05f-28c283997b34", 8.5, "SENIOR(65 & OVER)" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "3bb624cd-50c8-4227-bcce-f99061259819", 10.0, "ADULT" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "59e277de-c3fc-4c9c-84e9-ded3c6b36377", 8.5, "STUDENT" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "8a007cac-c7c7-4b1f-97f2-efd5aa65c4f0", 10.0, "CHILD (AGE 14 AND UNDER)" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "_price", "_ticketName" },
                values: new object[] { "eac31e45-3064-4a86-ae52-3a4947a74241", 32.0, "FAMILY X 4(2 AD + 2CH OR 1AD +3 CH)" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "0c6614ba-f633-4462-a05f-28c283997b34");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "3bb624cd-50c8-4227-bcce-f99061259819");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "59e277de-c3fc-4c9c-84e9-ded3c6b36377");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "8a007cac-c7c7-4b1f-97f2-efd5aa65c4f0");

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: "eac31e45-3064-4a86-ae52-3a4947a74241");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Booking",
                newName: "time");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Booking",
                newName: "movieId");

            migrationBuilder.RenameColumn(
                name: "Day",
                table: "Booking",
                newName: "day");

            migrationBuilder.AlterColumn<string>(
                name: "time",
                table: "Booking",
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
        }
    }
}
