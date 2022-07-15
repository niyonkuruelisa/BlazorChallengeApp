using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorChallengeApp.Server.Migrations
{
    public partial class AddedFewtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Cinema",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinema", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieCinema",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false),
                    CinemaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCinema", x => x.id);
                    table.ForeignKey(
                        name: "FK_MovieCinema_Cinema_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "Cinema",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieCinema_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Centry Cinema Kigali" });

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Canal Olympia Kigali" });

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Centry Cinema Ireland" });

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Canal Olympia France" });

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Centry Cinema UK" });

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Canal Olympia USA" });

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

            migrationBuilder.CreateIndex(
                name: "IX_MovieCinema_CinemaId",
                table: "MovieCinema",
                column: "CinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCinema_MovieId",
                table: "MovieCinema",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieCinema");

            migrationBuilder.DropTable(
                name: "Cinema");

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
    }
}
