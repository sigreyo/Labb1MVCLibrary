using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb1MVC_Simon.Migrations
{
    public partial class usernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Customers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 30 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 24 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 13 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 34 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 7 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 34 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 37 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 37 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                column: "LoanId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 11 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 6 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 31 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 30 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 39 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 27 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 37 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 36 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 16 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20,
                column: "LoanId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 21,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 28 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 22,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 23,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 13 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 24,
                column: "LoanId",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 25,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 33 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 26,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 24 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 27,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 17 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 28,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 10 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 29,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 13 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 30,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 14 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 31,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 9 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 32,
                column: "LoanId",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 33,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 24 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 34,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 22 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 35,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 27 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 36,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 15 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 37,
                column: "LoanId",
                value: 35);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 38,
                column: "LoanId",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 39,
                column: "LoanId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 40,
                column: "LoanId",
                value: 35);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Nikolaus Trail2197", "pixel Friesen", 13, "940-314-3628" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Rau Mountains1235", "bandwidth Ankunding", 30, "977-587-8238" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Crist Island152", "firewall Bogisich", 2, "302-224-2691" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Cheyanne Course714", "transmitter Roberts", 24, "931-592-2724" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Kozey Drive2211", "monitor Cummings", 9, "541-246-5076" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Dora Causeway1688", "matrix Satterfield", 38, "892-584-0939" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Frederique Villages358", "firewall Schimmel", 4, "889-801-8985" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Owen Club1035", "monitor Bechtelar", 26, "452-657-9774" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Berge Springs1951", "monitor Nader", 21, "978-254-0023" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Baumbach Island1097", "application Corkery", 37, "847-409-7321" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 11,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Crooks Road21", "program Huel", 37, "522-796-8734" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 12,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Volkman Oval2204", "port Kiehn", 10, "840-777-1244" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 13,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Hodkiewicz Meadow2197", "alarm King", 8, "454-555-5545" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 14,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Ora Branch56", "system Hessel", 13, "754-269-4554" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 15,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Roselyn Ville2267", "protocol Flatley", 4, "605-353-0822" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 16,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Predovic Mountain1309", "sensor Abernathy", 18, "444-964-9953" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 17,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Tracey Burg2085", "circuit Donnelly", 4, "404-594-6229" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 18,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Weimann Point488", "bus Ritchie", 3, "644-777-6124" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 19,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Beatty Curve502", "capacitor Leuschke", 12, "253-684-6405" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 20,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Jewell Ranch811", "bus Mertz", 4, "358-296-4543" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 21,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Camren Route436", "application Tremblay", 18, "926-661-9995" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 22,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Cristopher Groves2322", "circuit Lubowitz", 40, "876-590-8009" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 23,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Raymundo Stream23", "system Conn", 15, "890-704-7710" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 24,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Borer Streets583", "interface Bradtke", 14, "742-878-2084" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 25,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Gutkowski Lakes71", "interface Emmerich", 18, "607-468-5910" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 26,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Evan Crescent168", "capacitor Kshlerin", 27, "412-958-3752" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 27,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Arnold Plains372", "program Langworth", 27, "725-296-1864" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 28,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Heather Crossroad429", "interface Hammes", 33, "289-819-7378" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 29,
                columns: new[] { "Address", "FullName", "Phone" },
                values: new object[] { "Braden Tunnel1852", "protocol Volkman", "502-423-3924" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 30,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Theo Brooks1087", "bandwidth Borer", 17, "960-548-1966" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 31,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Clark Shore1855", "bandwidth Waters", 28, "869-896-8989" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 32,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Hagenes Radial1435", "hard drive Kerluke", 4, "431-466-3486" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 33,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Leola Vista261", "system Swaniawski", 33, "889-531-5113" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 34,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Jadon Harbor363", "system Veum", 2, "979-288-7565" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 35,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Hirthe Stravenue1782", "driver Dach", 30, "344-276-0261" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 36,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Sipes Dale1859", "transmitter Kris", 16, "672-727-5013" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 37,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Gibson Village1786", "system Johnson", 26, "392-446-3498" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 38,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Mina Way765", "panel Abernathy", 7, "366-262-7986" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 39,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Gail Drive691", "hard drive Schneider", 30, "824-481-6353" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 40,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Hackett Light1317", "port Herman", 25, "951-821-4271" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 1,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 13, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(801), 35 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 2,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 36, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1145), 23 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 3,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 27, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1159), 8 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 4,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 31, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1165), 5 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 5,
                columns: new[] { "BookId", "BookLoanDate" },
                values: new object[] { 21, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 6,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 8, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1176), 30 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 7,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 37, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1182), 7 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 8,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 31, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1187), 5 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 9,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 28, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1193), 28 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 10,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 20, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1239), 28 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 11,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 19, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1247), 32 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 12,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 38, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1253), 27 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 13,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 10, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1258), 14 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 14,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 9, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1264), 3 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 15,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 39, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1269), 17 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 16,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 31, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1274), 25 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 17,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 15, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1279), 33 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 18,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 40, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1285), 14 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 19,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 11, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1290), 13 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 20,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 14, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1296), 18 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 21,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 10, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1301), 34 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 22,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 26, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1306), 14 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 23,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 27, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1312), 29 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 24,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 5, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1318), 6 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 25,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 17, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1323), 2 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 26,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 14, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1328), 15 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 27,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 4, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1334), 4 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 28,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 14, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1339), 34 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 29,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 35, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1344), 35 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 30,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 38, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1350), 27 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 31,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 34, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1355), 15 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 32,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 8, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1361), 9 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 33,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 20, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1366), 37 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 34,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 38, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1372), 26 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 35,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 27, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1377), 20 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 36,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 27, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1382), 30 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 37,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 1, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1387), 7 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 38,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 24, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1393), 17 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 39,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 5, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1398), 18 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 40,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 11, new DateTime(2022, 9, 22, 9, 25, 16, 758, DateTimeKind.Local).AddTicks(1403), 16 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Customers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 24 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 30 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 25 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 14 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 35 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 5 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                column: "LoanId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 25 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 8 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 29 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 23 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 14 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 30 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 30 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 22 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 30 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 25 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20,
                column: "LoanId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 21,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 39 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 22,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 34 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 23,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 30 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 24,
                column: "LoanId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 25,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 11 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 26,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 16 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 27,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 7 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 28,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 19 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 29,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 14 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 30,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 23 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 31,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 35 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 32,
                column: "LoanId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 33,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 30 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 34,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 32 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 35,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 28 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 36,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 25 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 37,
                column: "LoanId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 38,
                column: "LoanId",
                value: 32);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 39,
                column: "LoanId",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 40,
                column: "LoanId",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Stationsvägen 59", "Cassandra Eriksson", 1, "5349-36855" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Perssons Gata 9", "Isaias Svensson", 27, "7450-63806" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Amaris Gata 354", "Michale Johansson", 15, "0636-89706" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Lindseys Väg 288", "Darrion Johansson", 3, "5007-94836" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Florines Väg 0", "Heather Eriksson", 10, "4644-68688" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Kyrkovägen 83", "Javon Andersson", 28, "6235-38112" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Olssons Gata 6", "Mavis Nilsson", 10, "6763-28540" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Devens Väg 693", "Diana Nilsson", 22, "6063-10119" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Åkerallén 47", "Pattie Persson", 3, "3089-36342" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Kyrkgärdet 2", "Jayde Karlsson", 29, "1561-46424" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 11,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Vicentas Gata 94", "Tessie Olsson", 18, "3522-99176" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 12,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Övre Skolvägen 776", "Neha Olsson", 11, "7963-53685" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 13,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Strandallén 0", "Ephraim Persson", 34, "1222-38751" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 14,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Nonas Väg 6", "Wilford Persson", 17, "9516-41014" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 15,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Strandgatan 6", "Destiny Larsson", 14, "3503-63930" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 16,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Novas Gata 6", "Reese Karlsson", 36, "5388-61201" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 17,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Londons Väg 7", "Karlee Persson", 39, "0822-93859" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 18,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Östra Ängsgränden 549", "Emmanuel Persson", 33, "2920-13445" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 19,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Östra Villagränden 834", "Murl Karlsson", 14, "5758-14266" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 20,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Ängsvägen 91", "Aryanna Svensson", 19, "9606-96282" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 21,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Skolgatan 33", "Lynn Karlsson", 3, "9978-30951" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 22,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Östra Åkergränden 4", "Zackary Olsson", 35, "5812-52309" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 23,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Stationsallén 75", "Wilburn Andersson", 39, "4302-06791" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 24,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Larssons Gata 894", "Violette Andersson", 39, "7175-23025" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 25,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Ringgränden 6", "Garfield Gustafsson", 4, "9905-35222" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 26,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Gengärdet 830", "Rosamond Johansson", 8, "8073-20980" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 27,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Bäckallén 137", "Mckenzie Andersson", 19, "7186-04385" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 28,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Skogsgärdet 694", "Jennyfer Larsson", 14, "1836-84244" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 29,
                columns: new[] { "Address", "FullName", "Phone" },
                values: new object[] { "Rays Väg 0", "Aida Persson", "7646-51098" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 30,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Övre Ringgränden 1", "Levi Olsson", 25, "6268-24169" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 31,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Ulisess Väg 12", "Elise Larsson", 7, "9444-59163" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 32,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Perssons Gata 6", "Marion Svensson", 32, "6702-67331" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 33,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Västra Furugatan 0", "Brianne Olsson", 32, "0428-09779" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 34,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Camerons Väg 604", "Jordyn Olsson", 16, "8907-71979" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 35,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Frederiks Gata 94", "Keshawn Nilsson", 25, "2194-78514" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 36,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Gustafssons Gata 167", "Jude Gustafsson", 36, "6275-80126" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 37,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Kyrkogränden 9", "Danyka Karlsson", 12, "6610-59121" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 38,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Genevieves Gata 402", "Uriel Persson", 30, "9659-23743" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 39,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Pamelas Gata 65", "Casimir Karlsson", 13, "6406-91738" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 40,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Svenssons Väg 97", "Alene Johansson", 6, "3133-78695" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 1,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 24, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(5950), 4 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 2,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 40, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6359), 3 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 3,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 2, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6370), 34 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 4,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 22, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6377), 29 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 5,
                columns: new[] { "BookId", "BookLoanDate" },
                values: new object[] { 6, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6382) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 6,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 21, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6387), 17 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 7,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 23, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6393), 22 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 8,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 18, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6398), 7 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 9,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 27, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6403), 22 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 10,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 30, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6408), 18 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 11,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 22, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6414), 38 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 12,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 29, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6419), 12 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 13,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 17, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6424), 39 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 14,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 1, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6472), 29 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 15,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 25, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6478), 2 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 16,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 7, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6483), 34 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 17,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 19, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6488), 10 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 18,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 3, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6493), 13 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 19,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 6, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6498), 27 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 20,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 37, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6504), 28 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 21,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 37, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6509), 32 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 22,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 6, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6514), 21 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 23,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 24, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6519), 32 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 24,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 32, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6524), 16 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 25,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 31, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6530), 21 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 26,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 10, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6535), 5 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 27,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 11, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6540), 13 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 28,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 23, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6545), 8 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 29,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 27, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6550), 9 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 30,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 34, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6555), 29 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 31,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 3, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6561), 18 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 32,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 1, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6566), 2 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 33,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 7, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6571), 15 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 34,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 28, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6576), 40 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 35,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 17, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6581), 4 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 36,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 16, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6586), 17 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 37,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 17, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6592), 12 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 38,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 11, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6597), 40 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 39,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 11, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6602), 34 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 40,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 5, new DateTime(2022, 9, 22, 9, 1, 24, 155, DateTimeKind.Local).AddTicks(6606), 3 });
        }
    }
}
