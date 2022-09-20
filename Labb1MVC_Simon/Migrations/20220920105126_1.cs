using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb1MVC_Simon.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ReleaseYear",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Amount", "Author", "Category", "Description", "LoanId", "PageCount", "ReleaseYear", "Thumbnail", "Title" },
                values: new object[,]
                {
                    { 1, 4, null, null, null, 40, null, null, null, null },
                    { 2, 5, null, null, null, 15, null, null, null, null },
                    { 3, 5, null, null, null, 14, null, null, null, null },
                    { 4, 5, null, null, null, 6, null, null, null, null },
                    { 5, 3, null, null, null, 12, null, null, null, null },
                    { 6, 2, null, null, null, 39, null, null, null, null },
                    { 7, 2, null, null, null, 23, null, null, null, null },
                    { 8, 1, null, null, null, 20, null, null, null, null },
                    { 9, 4, null, null, null, 28, null, null, null, null },
                    { 10, 3, null, null, null, 28, null, null, null, null },
                    { 11, 4, null, null, null, 13, null, null, null, null },
                    { 12, 2, null, null, null, 14, null, null, null, null },
                    { 13, 5, null, null, null, 38, null, null, null, null },
                    { 14, 5, null, null, null, 35, null, null, null, null },
                    { 15, 2, null, null, null, 12, null, null, null, null },
                    { 16, 3, null, null, null, 15, null, null, null, null },
                    { 17, 4, null, null, null, 38, null, null, null, null },
                    { 18, 2, null, null, null, 14, null, null, null, null },
                    { 19, 4, null, null, null, 25, null, null, null, null },
                    { 20, 1, null, null, null, 37, null, null, null, null },
                    { 21, 2, null, null, null, 17, null, null, null, null },
                    { 22, 1, null, null, null, 2, null, null, null, null },
                    { 23, 2, null, null, null, 1, null, null, null, null },
                    { 24, 3, null, null, null, 36, null, null, null, null },
                    { 25, 1, null, null, null, 4, null, null, null, null },
                    { 26, 5, null, null, null, 7, null, null, null, null },
                    { 27, 4, null, null, null, 11, null, null, null, null },
                    { 28, 5, null, null, null, 15, null, null, null, null },
                    { 29, 3, null, null, null, 21, null, null, null, null },
                    { 30, 2, null, null, null, 3, null, null, null, null },
                    { 31, 1, null, null, null, 11, null, null, null, null },
                    { 32, 4, null, null, null, 22, null, null, null, null },
                    { 33, 2, null, null, null, 33, null, null, null, null },
                    { 34, 5, null, null, null, 30, null, null, null, null },
                    { 35, 2, null, null, null, 28, null, null, null, null },
                    { 36, 2, null, null, null, 22, null, null, null, null },
                    { 37, 1, null, null, null, 10, null, null, null, null },
                    { 38, 3, null, null, null, 5, null, null, null, null },
                    { 39, 2, null, null, null, 34, null, null, null, null },
                    { 40, 2, null, null, null, 37, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "FirstName", "LastName", "LoanId", "Phone" },
                values: new object[,]
                {
                    { 1, "473 Joaquin Streets", "Concepcion", "Anderson", 20, "420-717-8359" },
                    { 2, "398 Barney Springs", "Elaina", "Tromp", 19, "686-450-8914" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "FirstName", "LastName", "LoanId", "Phone" },
                values: new object[,]
                {
                    { 3, "68126 Pacocha Harbors", "Annetta", "Durgan", 5, "720-663-8296" },
                    { 4, "69611 Quinn Roads", "Maxie", "Hackett", 27, "621-488-6236" },
                    { 5, "93583 Jenkins Motorway", "Genesis", "O'Hara", 28, "394-444-0789" },
                    { 6, "297 Kellen Fall", "Aidan", "Stehr", 23, "520-384-1295" },
                    { 7, "125 Schuppe Drives", "Axel", "Spencer", 29, "869-451-8650" },
                    { 8, "54328 Trinity Shore", "Raymond", "Schmitt", 25, "914-724-8624" },
                    { 9, "542 Bogisich Park", "Justice", "Daniel", 28, "648-565-3794" },
                    { 10, "8319 Rutherford Highway", "Torey", "Grant", 29, "559-325-7840" },
                    { 11, "502 Harber Manor", "Antonietta", "Pagac", 14, "828-607-2656" },
                    { 12, "0011 Ankunding Drive", "Fritz", "Torphy", 5, "580-831-2309" },
                    { 13, "34727 Logan Vista", "Joshua", "Spencer", 15, "894-597-5796" },
                    { 14, "896 Parker Drive", "Frederik", "Bosco", 25, "872-501-1084" },
                    { 15, "7107 Mayra Alley", "Shaylee", "Deckow", 26, "918-797-3598" },
                    { 16, "08027 Freida Route", "Elnora", "Rogahn", 7, "376-489-6738" },
                    { 17, "73686 Bode Ports", "Joey", "Halvorson", 28, "966-945-4655" },
                    { 18, "173 Erica Ports", "Howell", "Mosciski", 5, "367-995-5884" },
                    { 19, "7837 Wanda Shore", "Dan", "Murphy", 5, "394-486-5439" },
                    { 20, "9190 Telly Harbors", "Howard", "Crist", 4, "350-978-2883" },
                    { 21, "1088 Kertzmann Key", "Yvonne", "Breitenberg", 29, "975-756-2243" },
                    { 22, "9220 Lucinda Branch", "Kenna", "Dooley", 25, "917-372-5009" },
                    { 23, "06056 Emmalee Manors", "Erin", "Mayert", 25, "354-439-7542" },
                    { 24, "8282 Turcotte Canyon", "Barney", "McGlynn", 28, "602-600-1262" },
                    { 25, "90548 Frami Ports", "Junior", "Schulist", 20, "836-645-7081" },
                    { 26, "5434 Beatty Lights", "Gaylord", "Schowalter", 13, "562-588-5384" },
                    { 27, "3792 Gaylord Islands", "Noah", "Kuphal", 2, "392-970-4682" },
                    { 28, "9004 Lilyan Prairie", "Catherine", "Grady", 25, "685-713-9585" },
                    { 29, "54872 Justine Rapids", "Kennedi", "Torphy", 18, "331-244-9496" },
                    { 30, "29361 Senger Spring", "Alvis", "Stoltenberg", 14, "531-210-0539" },
                    { 31, "42489 Angelica Plain", "Alene", "Bednar", 16, "274-395-7192" },
                    { 32, "6074 Justina Streets", "Nicolette", "Daniel", 12, "820-807-8182" },
                    { 33, "456 Brekke Burgs", "Amber", "Dach", 25, "503-588-7785" },
                    { 34, "3225 Myriam Locks", "Myrtice", "O'Kon", 4, "947-334-7958" },
                    { 35, "590 Carlotta Dale", "Celestino", "Runolfsson", 16, "601-335-0189" },
                    { 36, "77581 Adell Greens", "Noah", "Kiehn", 23, "840-526-3399" },
                    { 37, "191 Wilber Village", "Raina", "Gulgowski", 27, "500-730-7897" },
                    { 38, "230 Rempel Burg", "Shana", "Kuhlman", 10, "922-752-8616" },
                    { 39, "090 Boris Throughway", "Estrella", "Quigley", 13, "518-435-1502" },
                    { 40, "3855 Desiree Lodge", "Afton", "Cronin", 16, "944-690-9246" }
                });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "LoanId", "BookId", "BookLoanDate", "BookReturnDate", "CustomerId", "DaysToLoan", "ReturnedInTime" },
                values: new object[,]
                {
                    { 1, 17, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6304), null, 8, 30, null },
                    { 2, 14, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6660), null, 16, 30, null },
                    { 3, 24, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6698), null, 14, 30, null },
                    { 4, 2, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6704), null, 8, 30, null },
                    { 5, 16, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6709), null, 27, 30, null },
                    { 6, 26, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6714), null, 23, 30, null },
                    { 7, 7, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6719), null, 18, 30, null },
                    { 8, 21, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6724), null, 28, 30, null },
                    { 9, 19, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6730), null, 26, 30, null },
                    { 10, 9, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6734), null, 17, 30, null },
                    { 11, 13, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6740), null, 13, 30, null },
                    { 12, 22, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6745), null, 26, 30, null },
                    { 13, 13, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6750), null, 30, 30, null },
                    { 14, 3, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6755), null, 19, 30, null },
                    { 15, 19, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6760), null, 11, 30, null },
                    { 16, 15, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6765), null, 19, 30, null },
                    { 17, 26, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6770), null, 21, 30, null },
                    { 18, 25, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6775), null, 24, 30, null },
                    { 19, 27, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6779), null, 17, 30, null },
                    { 20, 16, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6784), null, 6, 30, null },
                    { 21, 15, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6789), null, 1, 30, null },
                    { 22, 25, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6794), null, 13, 30, null },
                    { 23, 22, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6799), null, 10, 30, null },
                    { 24, 12, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6804), null, 23, 30, null },
                    { 25, 5, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6809), null, 13, 30, null },
                    { 26, 3, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6868), null, 24, 30, null },
                    { 27, 23, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6873), null, 22, 30, null },
                    { 28, 8, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6878), null, 1, 30, null },
                    { 29, 26, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6883), null, 20, 30, null },
                    { 30, 18, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6888), null, 26, 30, null },
                    { 31, 13, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6893), null, 29, 30, null },
                    { 32, 29, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6898), null, 20, 30, null },
                    { 33, 29, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6903), null, 7, 30, null },
                    { 34, 18, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6908), null, 2, 30, null },
                    { 35, 12, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6913), null, 15, 30, null },
                    { 36, 13, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6918), null, 19, 30, null },
                    { 37, 14, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6923), null, 4, 30, null },
                    { 38, 7, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6928), null, 6, 30, null },
                    { 39, 19, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6933), null, 3, 30, null },
                    { 40, 21, new DateTime(2022, 9, 20, 12, 51, 26, 250, DateTimeKind.Local).AddTicks(6938), null, 1, 30, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseYear",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
