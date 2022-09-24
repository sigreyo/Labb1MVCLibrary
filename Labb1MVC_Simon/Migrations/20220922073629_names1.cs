using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb1MVC_Simon.Migrations
{
    public partial class names1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 7 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "LoanId",
                value: 18);

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
                keyValue: 7,
                column: "LoanId",
                value: 5);

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
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 6 });

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
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 15 });

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
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 10 });

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
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 6 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20,
                column: "LoanId",
                value: 12);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Amount", "Author", "Category", "Description", "LoanId", "PageCount", "ReleaseYear", "Thumbnail", "Title" },
                values: new object[,]
                {
                    { 21, 4, null, null, null, 3, null, null, null, null },
                    { 22, 5, null, null, null, 23, null, null, null, null },
                    { 23, 2, null, null, null, 11, null, null, null, null },
                    { 24, 2, null, null, null, 30, null, null, null, null },
                    { 25, 3, null, null, null, 22, null, null, null, null },
                    { 26, 1, null, null, null, 19, null, null, null, null },
                    { 27, 2, null, null, null, 2, null, null, null, null },
                    { 28, 3, null, null, null, 30, null, null, null, null },
                    { 29, 4, null, null, null, 23, null, null, null, null },
                    { 30, 4, null, null, null, 15, null, null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Legros Inlet 1402", "Edmond Gislason", 10, "999-437-4728" });

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

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "FullName", "LoanId", "Phone" },
                values: new object[,]
                {
                    { 21, "Kihn Lodge 431", "Vernon Pouros", 16, "986-428-7341" },
                    { 22, "Crona Inlet 134", "Leopold Veum", 4, "682-981-2508" },
                    { 23, "Thalia Orchard 859", "Izaiah Crona", 22, "912-571-0684" },
                    { 24, "Brenna Neck 1104", "Sunny Mayer", 22, "852-234-3478" },
                    { 25, "Wilford Light 1499", "Graham Padberg", 14, "914-755-2595" },
                    { 26, "Grady Fork 1049", "Tianna Cassin", 6, "357-988-1061" },
                    { 27, "Veum Mountain 1635", "Jordon Terry", 7, "922-259-8705" },
                    { 28, "Hugh Fall 278", "Greyson Considine", 27, "869-795-3808" },
                    { 29, "Bradtke Circle 383", "Shanna Stracke", 16, "741-291-0801" },
                    { 30, "Ebba Station 1353", "Velda Schimmel", 6, "654-470-2095" }
                });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 2,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 16, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5654), 13 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 4,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 10, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5674), 4 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 6,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 8, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5688), 3 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 8,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 16, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5701), 13 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 12,
                columns: new[] { "BookLoanDate", "CustomerId" },
                values: new object[] { new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5726), 6 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 14,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 12, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5738), 17 });

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

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "LoanId", "BookId", "BookLoanDate", "BookReturnDate", "CustomerId", "DaysToLoan", "ReturnedInTime" },
                values: new object[,]
                {
                    { 23, 13, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5793), null, 17, 30, null },
                    { 24, 12, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5799), null, 13, 30, null },
                    { 26, 9, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5811), null, 6, 30, null },
                    { 27, 8, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5817), null, 10, 30, null },
                    { 29, 15, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5828), null, 3, 30, null }
                });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 1,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 28, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5204), 22 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 3,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 21, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5667), 18 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 5,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 12, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5681), 21 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 7,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 25, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5694), 3 });

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
                keyValue: 13,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 25, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5732), 11 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 15,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 28, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5744), 20 });

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

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "LoanId", "BookId", "BookLoanDate", "BookReturnDate", "CustomerId", "DaysToLoan", "ReturnedInTime" },
                values: new object[,]
                {
                    { 21, 27, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5781), null, 14, 30, null },
                    { 22, 23, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5787), null, 4, 30, null },
                    { 25, 24, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5805), null, 4, 30, null },
                    { 28, 21, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5823), null, 28, 30, null },
                    { 30, 18, new DateTime(2022, 9, 22, 9, 36, 29, 27, DateTimeKind.Local).AddTicks(5834), null, 22, 30, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 22);

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
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 21);

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
                keyValue: 25);

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
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 30);

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
                table: "Books",
                keyColumn: "BookId",
                keyValue: 21);

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
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 28);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 12 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "LoanId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 6 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 12 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 10 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                column: "LoanId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 15 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                column: "LoanId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                column: "LoanId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 6 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 12 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 8 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 18 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 6 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 15 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 7 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 14 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20,
                column: "LoanId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Reid Hollow 555", "Chester Miller", 29, "563-777-7149" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Aiyana Fork 2033", "Jamey Maggio", 21, "447-227-8455" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Schowalter Highway 1456", "Magdalen Hills", 38, "867-557-7339" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Bosco Light 392", "Anthony Carter", 39, "728-758-0874" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Tomasa Glen 2348", "Litzy Gibson", 14, "783-628-3738" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Kerluke Green 991", "Keaton Homenick", 34, "231-352-6093" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Jerde Fort 558", "Alfreda Prohaska", 2, "939-328-9138" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Crooks Plaza 1564", "Jan Swaniawski", 23, "536-265-4586" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Becker Road 1582", "Dustin Cormier", 11, "730-688-1387" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Harvey Throughway 325", "Tony Runolfsdottir", 20, "319-369-5237" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 11,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Jerrold Plaza 1654", "Arjun Metz", 34, "983-963-7238" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 12,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Vito Parkway 746", "Burnice Windler", 13, "819-896-0751" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 13,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Reinger Mall 1152", "Beau Hilpert", 20, "380-728-4466" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 14,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Trantow Skyway 636", "Tressa Jenkins", 32, "782-995-2006" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 15,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Alexander Road 43", "Loraine Towne", 13, "786-329-0335" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 16,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Rolando Gardens 29", "Alfonzo Ankunding", 28, "388-480-4923" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 17,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Collins Oval 236", "Ceasar Weimann", 5, "884-236-8848" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 18,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Jaida Forest 598", "Freda Jakubowski", 25, "812-680-0816" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 19,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Georgiana Drive 941", "Brad Murazik", 10, "585-277-3941" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 20,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Schmitt Manor 2088", "Merritt Kutch", 6, "910-706-0759" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 1,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 14, new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7464), 9 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 2,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 20, new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7845), 7 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 3,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 17, new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7858), 17 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 4,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 17, new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7864), 3 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 5,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 8, new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7870), 11 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 6,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 14, new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7876), 8 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 7,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 2, new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7882), 19 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 8,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 12, new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7887), 15 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 9,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 20, new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7892), 4 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 10,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 4, new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7898), 19 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 11,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 17, new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7903), 20 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 12,
                columns: new[] { "BookLoanDate", "CustomerId" },
                values: new object[] { new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7908), 14 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 13,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 8, new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7914), 5 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 14,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 19, new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7919), 16 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 15,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 10, new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7925), 16 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 16,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 20, new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7930), 12 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 17,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 4, new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7935), 10 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 18,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 5, new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7941), 14 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 19,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 18, new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7946), 7 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 20,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 2, new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7951), 17 });
        }
    }
}
