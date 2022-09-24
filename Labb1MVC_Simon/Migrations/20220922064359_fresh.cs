using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb1MVC_Simon.Migrations
{
    public partial class fresh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageCount = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    LoanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    LoanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookLoanDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DaysToLoan = table.Column<int>(type: "int", nullable: false),
                    ReturnedInTime = table.Column<bool>(type: "bit", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.LoanId);
                    table.ForeignKey(
                        name: "FK_Loans_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loans_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Amount", "Author", "Category", "Description", "LoanId", "PageCount", "ReleaseYear", "Thumbnail", "Title" },
                values: new object[,]
                {
                    { 1, 2, null, null, null, 33, null, null, null, null },
                    { 2, 4, null, null, null, 40, null, null, null, null },
                    { 3, 2, null, null, null, 23, null, null, null, null },
                    { 4, 5, null, null, null, 39, null, null, null, null },
                    { 5, 4, null, null, null, 5, null, null, null, null },
                    { 6, 5, null, null, null, 6, null, null, null, null },
                    { 7, 3, null, null, null, 32, null, null, null, null },
                    { 8, 3, null, null, null, 37, null, null, null, null },
                    { 9, 2, null, null, null, 39, null, null, null, null },
                    { 10, 1, null, null, null, 36, null, null, null, null },
                    { 11, 4, null, null, null, 2, null, null, null, null },
                    { 12, 5, null, null, null, 5, null, null, null, null },
                    { 13, 3, null, null, null, 30, null, null, null, null },
                    { 14, 5, null, null, null, 27, null, null, null, null },
                    { 15, 3, null, null, null, 33, null, null, null, null },
                    { 16, 2, null, null, null, 34, null, null, null, null },
                    { 17, 4, null, null, null, 22, null, null, null, null },
                    { 18, 4, null, null, null, 9, null, null, null, null },
                    { 19, 2, null, null, null, 38, null, null, null, null },
                    { 20, 2, null, null, null, 33, null, null, null, null },
                    { 21, 3, null, null, null, 20, null, null, null, null },
                    { 22, 1, null, null, null, 33, null, null, null, null },
                    { 23, 4, null, null, null, 29, null, null, null, null },
                    { 24, 5, null, null, null, 36, null, null, null, null },
                    { 25, 2, null, null, null, 15, null, null, null, null },
                    { 26, 3, null, null, null, 13, null, null, null, null },
                    { 27, 2, null, null, null, 37, null, null, null, null },
                    { 28, 5, null, null, null, 23, null, null, null, null },
                    { 29, 2, null, null, null, 35, null, null, null, null },
                    { 30, 5, null, null, null, 40, null, null, null, null },
                    { 31, 5, null, null, null, 28, null, null, null, null },
                    { 32, 5, null, null, null, 23, null, null, null, null },
                    { 33, 3, null, null, null, 1, null, null, null, null },
                    { 34, 1, null, null, null, 24, null, null, null, null },
                    { 35, 3, null, null, null, 11, null, null, null, null },
                    { 36, 5, null, null, null, 2, null, null, null, null },
                    { 37, 2, null, null, null, 25, null, null, null, null },
                    { 38, 2, null, null, null, 3, null, null, null, null },
                    { 39, 4, null, null, null, 27, null, null, null, null },
                    { 40, 4, null, null, null, 23, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "FullName", "LoanId", "Phone" },
                values: new object[,]
                {
                    { 1, "Larssons Väg 1", "Braulio Gustafsson", 7, "8810-96478" },
                    { 2, "Norra Nygatan 60", "Julianne Johansson", 3, "3531-36682" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "FullName", "LoanId", "Phone" },
                values: new object[,]
                {
                    { 3, "Kyrkgärdet 422", "Alexandria Nilsson", 28, "7109-41709" },
                    { 4, "Grangatan 0", "Brycen Karlsson", 5, "9850-52970" },
                    { 5, "Södra Bäckgränden 98", "Anne Persson", 30, "9454-89844" },
                    { 6, "Furugränden 4", "Jayme Eriksson", 10, "1509-97458" },
                    { 7, "Skogsgränden 54", "Adelle Andersson", 5, "6131-43572" },
                    { 8, "Södra Skolvägen 36", "Maribel Svensson", 25, "6316-58706" },
                    { 9, "Svenssons Väg 70", "Thurman Larsson", 30, "6153-51157" },
                    { 10, "Furugränden 3", "Asia Johansson", 30, "6108-61166" },
                    { 11, "Undre Kvarngränden 06", "Newell Johansson", 16, "4496-52813" },
                    { 12, "Undre Åkergränden 70", "Arjun Olsson", 28, "7507-91059" },
                    { 13, "Omaris Väg 46", "Amy Gustafsson", 13, "7649-41844" },
                    { 14, "Anderssons Gata 820", "Cade Andersson", 8, "8599-09969" },
                    { 15, "Fabriksgatan 055", "Clovis Larsson", 3, "1205-41622" },
                    { 16, "Norra Strandgatan 96", "Angelica Johansson", 20, "6504-23795" },
                    { 17, "Anaiss Väg 36", "Courtney Larsson", 3, "4230-78084" },
                    { 18, "Olssons Gata 499", "Randall Nilsson", 7, "2008-59811" },
                    { 19, "Leras Väg 94", "Frances Nilsson", 28, "6932-54904" },
                    { 20, "Johanssons Gata 340", "Eloy Persson", 29, "6297-52186" },
                    { 21, "Johnsons Gata 48", "Stephanie Eriksson", 22, "7974-90106" },
                    { 22, "Johanssons Gata 028", "Wilfrid Eriksson", 8, "2286-22865" },
                    { 23, "Perssons Gata 6", "Toy Larsson", 14, "0063-87318" },
                    { 24, "Nilssons Gata 80", "Minerva Svensson", 14, "7687-29847" },
                    { 25, "Kobys Gata 7", "Tamia Andersson", 9, "4646-91375" },
                    { 26, "Norra Trädgårdgatan 321", "Michale Larsson", 20, "1656-10146" },
                    { 27, "Ringgränden 631", "Rosina Larsson", 15, "3392-46507" },
                    { 28, "Idrottsgatan 344", "Kailee Svensson", 24, "6061-24327" },
                    { 29, "Svenssons Väg 3", "Lia Andersson", 12, "1166-46545" },
                    { 30, "Gengärdet 4", "Antonetta Svensson", 1, "2503-48748" },
                    { 31, "Karlssons Väg 7", "Brandi Eriksson", 4, "9182-54142" },
                    { 32, "Cathys Väg 41", "Houston Olsson", 20, "6922-68292" },
                    { 33, "Mathews Gata 693", "Scarlett Nilsson", 10, "8338-66571" },
                    { 34, "Chelseys Väg 147", "Selmer Svensson", 24, "0188-73038" },
                    { 35, "Myrties Väg 6", "Jadyn Karlsson", 19, "8831-89146" },
                    { 36, "Johanssons Gata 6", "Osborne Eriksson", 5, "3650-14707" },
                    { 37, "Ängsgärdet 5", "Norma Eriksson", 1, "2883-44595" },
                    { 38, "Sedricks Väg 5", "Billie Karlsson", 25, "2835-43686" },
                    { 39, "Västra Idrottsallén 418", "Burdette Svensson", 21, "9818-51038" },
                    { 40, "Norra Ringgärdet 910", "Orin Karlsson", 28, "6571-88382" }
                });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "LoanId", "BookId", "BookLoanDate", "BookReturnDate", "CustomerId", "DaysToLoan", "ReturnedInTime" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(7902), null, 20, 30, null },
                    { 2, 3, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8229), null, 21, 30, null },
                    { 3, 22, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8280), null, 7, 30, null },
                    { 4, 3, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8288), null, 27, 30, null },
                    { 5, 27, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8295), null, 7, 30, null },
                    { 6, 6, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8300), null, 23, 30, null },
                    { 7, 22, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8305), null, 11, 30, null },
                    { 8, 8, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8311), null, 28, 30, null },
                    { 9, 17, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8316), null, 3, 30, null },
                    { 10, 4, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8321), null, 12, 30, null },
                    { 11, 21, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8326), null, 28, 30, null },
                    { 12, 17, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8332), null, 12, 30, null },
                    { 13, 19, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8337), null, 9, 30, null },
                    { 14, 28, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8342), null, 24, 30, null },
                    { 15, 18, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8347), null, 29, 30, null },
                    { 16, 30, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8353), null, 5, 30, null },
                    { 17, 12, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8358), null, 22, 30, null },
                    { 18, 3, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8363), null, 23, 30, null },
                    { 19, 17, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8368), null, 21, 30, null },
                    { 20, 6, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8373), null, 9, 30, null },
                    { 21, 2, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8378), null, 17, 30, null },
                    { 22, 4, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8383), null, 1, 30, null },
                    { 23, 11, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8388), null, 28, 30, null },
                    { 24, 27, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8393), null, 29, 30, null },
                    { 25, 30, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8399), null, 17, 30, null },
                    { 26, 9, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8404), null, 20, 30, null },
                    { 27, 6, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8409), null, 21, 30, null },
                    { 28, 3, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8415), null, 13, 30, null },
                    { 29, 16, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8420), null, 15, 30, null },
                    { 30, 16, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8425), null, 8, 30, null },
                    { 31, 24, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8430), null, 17, 30, null },
                    { 32, 28, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8435), null, 28, 30, null },
                    { 33, 21, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8440), null, 9, 30, null },
                    { 34, 9, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8445), null, 4, 30, null },
                    { 35, 23, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8451), null, 17, 30, null },
                    { 36, 18, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8456), null, 21, 30, null },
                    { 37, 14, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8461), null, 14, 30, null },
                    { 38, 6, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8466), null, 24, 30, null },
                    { 39, 8, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8471), null, 3, 30, null },
                    { 40, 2, new DateTime(2022, 9, 22, 8, 43, 59, 735, DateTimeKind.Local).AddTicks(8476), null, 9, 30, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Loans_BookId",
                table: "Loans",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_CustomerId",
                table: "Loans",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
