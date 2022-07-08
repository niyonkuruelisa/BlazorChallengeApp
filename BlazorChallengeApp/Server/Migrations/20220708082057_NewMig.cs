using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorChallengeApp.Server.Migrations
{
    public partial class NewMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    day = table.Column<string>(type: "TEXT", nullable: true),
                    time = table.Column<string>(type: "TEXT", nullable: true),
                    movieId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RunningTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Mon = table.Column<string>(type: "TEXT", nullable: true),
                    Tue = table.Column<string>(type: "TEXT", nullable: true),
                    Wed = table.Column<string>(type: "TEXT", nullable: true),
                    Thu = table.Column<string>(type: "TEXT", nullable: true),
                    Fri = table.Column<string>(type: "TEXT", nullable: true),
                    Sat = table.Column<string>(type: "TEXT", nullable: true),
                    Sun = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RunningTimes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    _ticketName = table.Column<string>(type: "TEXT", nullable: false),
                    _price = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seat",
                columns: table => new
                {
                    id = table.Column<string>(type: "TEXT", nullable: false),
                    row = table.Column<int>(type: "INTEGER", nullable: false),
                    column = table.Column<int>(type: "INTEGER", nullable: false),
                    state = table.Column<string>(type: "TEXT", nullable: false),
                    BookingId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seat", x => x.id);
                    table.ForeignKey(
                        name: "FK_Seat_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Director = table.Column<string>(type: "TEXT", nullable: false),
                    Cast = table.Column<string>(type: "TEXT", nullable: false),
                    Genre = table.Column<string>(type: "TEXT", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: true),
                    RunningTimesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movie_RunningTimes_RunningTimesId",
                        column: x => x.RunningTimesId,
                        principalTable: "RunningTimes",
                        principalColumn: "Id");
                });

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
                name: "IX_Movie_RunningTimesId",
                table: "Movie",
                column: "RunningTimesId");

            migrationBuilder.CreateIndex(
                name: "IX_Seat_BookingId",
                table: "Seat",
                column: "BookingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "Seat");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "RunningTimes");

            migrationBuilder.DropTable(
                name: "Booking");
        }
    }
}
