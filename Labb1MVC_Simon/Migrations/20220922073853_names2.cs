using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb1MVC_Simon.Migrations
{
    public partial class names2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "LoanId",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 37 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 36 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 40 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 8 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 21 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 36 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                column: "LoanId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                column: "LoanId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                column: "LoanId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12,
                column: "LoanId",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 27 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 18 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 20 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16,
                column: "LoanId",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 35 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 34 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19,
                column: "LoanId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 32 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 21,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 15 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 22,
                column: "LoanId",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 23,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 25 });

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
                values: new object[] { 1, 33 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 26,
                column: "LoanId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 27,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 22 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 28,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 8 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 29,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 39 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 30,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 40 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Amount", "Author", "Category", "Description", "LoanId", "PageCount", "ReleaseYear", "Thumbnail", "Title" },
                values: new object[,]
                {
                    { 31, 3, null, null, null, 16, null, null, null, null },
                    { 32, 5, null, null, null, 32, null, null, null, null },
                    { 33, 4, null, null, null, 24, null, null, null, null },
                    { 34, 3, null, null, null, 28, null, null, null, null },
                    { 35, 5, null, null, null, 2, null, null, null, null },
                    { 36, 3, null, null, null, 3, null, null, null, null },
                    { 37, 2, null, null, null, 15, null, null, null, null },
                    { 38, 2, null, null, null, 36, null, null, null, null },
                    { 39, 1, null, null, null, 7, null, null, null, null },
                    { 40, 1, null, null, null, 27, null, null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "Address", "FullName", "Phone" },
                values: new object[] { "Madelyn Pike 708", "Hanna Veum", "237-758-0400" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Osinski Meadows 340", "Jillian Turner", 29, "763-889-0838" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Kamren Springs 1034", "Edwina Thiel", 5, "948-947-4684" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Fahey Square 1190", "Iva Bashirian", 32, "436-576-0436" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Kunze Valley 369", "Leif Haag", 23, "414-935-5586" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Helmer Drive 715", "Dayna Moen", 26, "592-492-6292" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Ryan Flat 500", "Kelvin Keebler", 7, "880-402-7718" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Predovic Summit 148", "Winston Runolfsdottir", 15, "358-656-1155" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Newton Mission 746", "Eliza Koch", 34, "424-925-6298" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Schumm Place 2124", "Tia Zulauf", 24, "531-541-7182" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 11,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Nadia Plaza 987", "Isac Daugherty", 33, "621-380-9585" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 12,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Carolanne River 1148", "Elvera Mertz", 33, "279-526-7175" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 13,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Orn Ports 479", "Gonzalo Parker", 17, "999-224-7538" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 14,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Haleigh Inlet 506", "Orie Dach", 16, "378-208-5789" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 15,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Frankie Road 1621", "Lynn Wiza", 19, "502-987-3003" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 16,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Kovacek Lake 2159", "Mitchell Fadel", 23, "393-565-5240" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 17,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Volkman Viaduct 1074", "Ford Halvorson", 11, "569-362-7078" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 18,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Friesen Orchard 164", "Watson Cole", 38, "506-997-3960" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 19,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Pedro Crossing 1656", "Rosalyn Swaniawski", 15, "908-396-1450" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 20,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Lemke Trace 2419", "Nola Waters", 27, "446-246-2137" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 21,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Reilly Walks 209", "Brooke Jones", 11, "738-461-3580" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 22,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Beahan Gateway 1749", "Ignacio Rutherford", 35, "207-260-2141" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 23,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "White Meadow 2332", "Xavier Bashirian", 10, "353-390-6219" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 24,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Lemke Underpass 940", "Charles Waters", 21, "938-381-7316" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 25,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Gerlach Corner 716", "Beaulah Toy", 17, "535-947-0324" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 26,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Rosenbaum Burg 1210", "Kaleb Keebler", 32, "357-741-2166" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 27,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Alanis Passage 1986", "Will Gerhold", 9, "392-911-6069" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 28,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Baumbach Port 1245", "Onie Wilkinson", 11, "966-494-0003" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 29,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Hartmann Loaf 901", "Brooklyn Wintheiser", 36, "589-992-2451" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 30,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Keeling Mews 2246", "Bertha Shanahan", 18, "569-921-7678" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "FullName", "LoanId", "Phone" },
                values: new object[,]
                {
                    { 31, "Corine Parkways 2148", "Zander Schmeler", 10, "688-211-7595" },
                    { 32, "Assunta Curve 1458", "Jaiden Rogahn", 1, "338-517-2524" },
                    { 33, "Kihn Glen 2256", "Jonathan Kuphal", 9, "720-732-1334" },
                    { 34, "Mireille Point 725", "Jedediah Herman", 11, "517-661-5400" },
                    { 35, "Kuhlman Bypass 2146", "Mandy Corwin", 37, "376-270-6080" },
                    { 36, "Ledner Freeway 36", "Barton DuBuque", 16, "631-504-7449" },
                    { 37, "Windler Shoal 1144", "Daisha Sanford", 33, "286-330-6725" },
                    { 38, "Rogahn Passage 13", "Vallie Upton", 16, "487-760-0080" },
                    { 39, "Ellie Pines 1671", "Eli Runolfsson", 38, "649-805-3654" },
                    { 40, "Hammes Inlet 1125", "Retta West", 38, "476-986-9315" }
                });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 1,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 7, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(130), 13 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 2,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 5, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(536), 14 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 5,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 24, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(601), 29 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 7,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 18, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(612), 2 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 9,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 20, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(623), 26 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 10,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 27, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(628), 4 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 11,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 21, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(633), 17 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 13,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 13, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(644), 2 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 14,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 29, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(649), 4 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 16,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 17, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(659), 25 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 18,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 28, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(669), 11 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 19,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 19, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(674), 24 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 24,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 20, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(700), 1 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 25,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 14, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(706), 27 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 27,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 23, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(716), 20 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 28,
                columns: new[] { "BookId", "BookLoanDate" },
                values: new object[] { 11, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(721) });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "LoanId", "BookId", "BookLoanDate", "BookReturnDate", "CustomerId", "DaysToLoan", "ReturnedInTime" },
                values: new object[,]
                {
                    { 31, 16, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(737), null, 11, 30, null },
                    { 34, 22, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(752), null, 18, 30, null },
                    { 35, 13, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(758), null, 7, 30, null },
                    { 36, 29, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(763), null, 17, 30, null },
                    { 37, 16, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(768), null, 19, 30, null },
                    { 38, 19, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(773), null, 14, 30, null }
                });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 3,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 33, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(588), 27 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 4,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 39, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(595), 29 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 6,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 4, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(607), 31 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 8,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 33, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(618), 14 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 12,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 3, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(638), 39 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 15,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 33, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(654), 37 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 17,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 17, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(664), 38 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 20,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 34, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(680), 12 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 21,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 36, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(685), 28 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 22,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 35, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(690), 40 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 23,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 6, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(695), 37 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 26,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 33, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(711), 34 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 29,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 32, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(727), 1 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 30,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 26, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(732), 40 });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "LoanId", "BookId", "BookLoanDate", "BookReturnDate", "CustomerId", "DaysToLoan", "ReturnedInTime" },
                values: new object[,]
                {
                    { 32, 13, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(742), null, 37, 30, null },
                    { 33, 29, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(748), null, 32, 30, null },
                    { 39, 23, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(778), null, 40, 30, null },
                    { 40, 40, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(783), null, 5, 30, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 31);

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
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 39);

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
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 40);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "LoanId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 18 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 7 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 17 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 17 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 5 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                column: "LoanId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                column: "LoanId",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                column: "LoanId",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12,
                column: "LoanId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 17 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16,
                column: "LoanId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 18 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19,
                column: "LoanId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 12 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 21,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 22,
                column: "LoanId",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 23,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 11 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 24,
                column: "LoanId",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 25,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 22 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 26,
                column: "LoanId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 27,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 28,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 30 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 29,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 23 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 30,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 15 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "Address", "FullName", "Phone" },
                values: new object[] { "Legros Inlet 1402", "Edmond Gislason", "999-437-4728" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Lyda Plains 2112", "Janiya Monahan", 26, "589-347-4268" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Ewald Trail 1521", "Rolando Rohan", 13, "864-538-2379" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Elise Falls 499", "Jennings Krajcik", 21, "987-844-4129" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Labadie Points 1673", "Haylie Ryan", 24, "297-526-0633" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Jessyca Path 1437", "River Casper", 9, "515-790-5811" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Elwyn Parkway 2181", "Carlee Mertz", 5, "472-657-6931" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Kutch Curve 1462", "Oswald Parker", 25, "911-637-9442" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Foster Shoal 1173", "Rahul Hand", 9, "777-753-1945" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Jordi Parkway 1893", "Pattie Kiehn", 2, "748-593-9181" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 11,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Jefferey Crossing 475", "Myrtice Hilll", 2, "851-959-0964" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 12,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Daisy Shore 940", "Kaia Zieme", 23, "379-511-8094" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 13,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Alize Ports 1390", "Deontae Wintheiser", 26, "328-786-6745" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 14,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Zena Mall 636", "Marcelina Crist", 21, "681-846-2478" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 15,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Schuppe Greens 733", "Samir Huel", 21, "726-255-9289" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 16,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Bergnaum Rapid 1252", "Larry Denesik", 11, "445-666-0751" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 17,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Rau Station 32", "Reyes Fahey", 24, "725-730-5718" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 18,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Cruickshank Mount 346", "Louie O'Connell", 21, "985-274-8215" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 19,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Raul Locks 1199", "Juliana Romaguera", 19, "630-228-9959" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 20,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Wolff Islands 144", "Freddie Cummerata", 8, "938-653-4282" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 21,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Kihn Lodge 431", "Vernon Pouros", 16, "986-428-7341" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 22,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Crona Inlet 134", "Leopold Veum", 4, "682-981-2508" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 23,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Thalia Orchard 859", "Izaiah Crona", 22, "912-571-0684" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 24,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Brenna Neck 1104", "Sunny Mayer", 22, "852-234-3478" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 25,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Wilford Light 1499", "Graham Padberg", 14, "914-755-2595" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 26,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Grady Fork 1049", "Tianna Cassin", 6, "357-988-1061" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 27,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Veum Mountain 1635", "Jordon Terry", 7, "922-259-8705" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 28,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Hugh Fall 278", "Greyson Considine", 27, "869-795-3808" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 29,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Bradtke Circle 383", "Shanna Stracke", 16, "741-291-0801" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 30,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Ebba Station 1353", "Velda Schimmel", 6, "654-470-2095" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 1,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 28, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5204), 22 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 2,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 16, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5654), 13 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 3,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 21, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5667), 18 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 4,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 10, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5674), 4 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 5,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 12, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5681), 21 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 6,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 8, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5688), 3 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 7,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 25, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5694), 3 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 8,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 16, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5701), 13 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 9,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 3, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5707), 29 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 10,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 1, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5713), 21 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 11,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 2, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5719), 22 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 12,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 10, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5726), 6 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 13,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 25, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5732), 11 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 14,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 12, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5738), 17 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 15,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 28, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5744), 20 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 16,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 2, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5750), 1 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 17,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 7, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5756), 12 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 18,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 10, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5762), 1 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 19,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 26, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5769), 6 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 20,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 23, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5775), 4 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 21,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 27, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5781), 14 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 22,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 23, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5787), 4 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 23,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 13, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5793), 17 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 24,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 12, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5799), 13 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 25,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 24, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5805), 4 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 26,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 9, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5811), 6 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 27,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 8, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5817), 10 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 28,
                columns: new[] { "BookId", "BookLoanDate" },
                values: new object[] { 21, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 29,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 15, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5828), 3 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 30,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 18, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5834), 22 });
        }
    }
}
