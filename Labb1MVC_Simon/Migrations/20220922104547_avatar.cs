using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb1MVC_Simon.Migrations
{
    public partial class avatar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 21 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "LoanId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 33 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 28 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 31 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                column: "LoanId",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                column: "LoanId",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                column: "LoanId",
                value: 34);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 10 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 16 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 8 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 40 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14,
                column: "LoanId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 35 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 33 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 32 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 15 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 21,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 28 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 22,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 13 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 23,
                column: "LoanId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 24,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 25,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 6 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 26,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 32 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 27,
                column: "LoanId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 28,
                column: "LoanId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 29,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 16 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 30,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 10 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 31,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 13 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 32,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 33 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 33,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 34,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 35,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 30 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 36,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 24 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 37,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 12 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 38,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 38 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 39,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 9 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 40,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 35 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "Address", "Avatar", "FullName", "Phone" },
                values: new object[] { "Koelpin Crest 2323", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1030.jpg", "Robb Pollich", "855-867-3773" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Alanis Estate 562", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/934.jpg", "Kendrick Schmidt", 26, "754-762-7955" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Hackett Burg 1728", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/768.jpg", "Alfreda Herman", 32, "743-422-7786" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Annetta Shores 1309", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/969.jpg", "Josianne Sauer", 19, "918-216-5073" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Marcus Light 326", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/847.jpg", "Neil Torphy", 14, "241-851-2829" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Padberg Highway 2055", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/362.jpg", "Kassandra Kris", 23, "733-599-9423" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Pollich Pike 1245", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1105.jpg", "Consuelo Runolfsson", 11, "263-778-9800" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Barton Stream 1933", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/912.jpg", "Clemens Kohler", 32, "257-371-0204" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Lynch Wall 2082", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/376.jpg", "Riley Shields", 15, "350-851-0442" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Bechtelar Mission 1508", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/274.jpg", "Curt Schoen", 26, "487-597-1357" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 11,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Rolfson Plaza 886", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/457.jpg", "Armand Rosenbaum", 40, "992-281-4233" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 12,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Tremblay Plaza 1335", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/239.jpg", "Erick MacGyver", 30, "424-336-7916" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 13,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Santino Via 1687", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/387.jpg", "Kayden Schmitt", 21, "218-941-2928" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 14,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Lilliana Rue 240", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1074.jpg", "Lexus Rutherford", 18, "544-258-1071" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 15,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Walton Locks 1350", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1248.jpg", "Kurt Bartoletti", 40, "992-791-4022" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 16,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Green Station 1170", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/80.jpg", "Concepcion Feest", 11, "462-531-7180" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 17,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Ettie Crossing 471", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1015.jpg", "Malvina Connelly", 9, "331-859-7302" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 18,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Hattie Lights 974", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/904.jpg", "Rita Lowe", 4, "678-343-2323" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 19,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Luettgen Viaduct 329", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/916.jpg", "Elvera Larson", 10, "455-800-8107" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 20,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Roy Burgs 607", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/648.jpg", "Beth Hamill", 22, "498-270-6025" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 21,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Raymundo Rest 35", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/971.jpg", "Maci Lubowitz", 9, "498-793-4071" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 22,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Amaya Summit 2044", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/69.jpg", "Stephanie Kilback", 28, "504-307-1353" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 23,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "West Burgs 63", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/143.jpg", "Meghan White", 9, "878-657-3359" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 24,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Kiarra Forks 1931", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/389.jpg", "Everett Boyle", 16, "783-467-1515" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 25,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Miller Springs 34", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/555.jpg", "Skye Osinski", 10, "386-521-6231" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 26,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Thiel Manor 2006", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/388.jpg", "Precious Daniel", 24, "757-780-8325" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 27,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Purdy Hollow 591", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/345.jpg", "Bettie Wiza", 39, "327-719-8917" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 28,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Huels Knoll 341", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/901.jpg", "Berry Turcotte", 26, "878-530-4094" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 29,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Jarred Mountains 1857", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/623.jpg", "Leann MacGyver", 40, "945-623-5556" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 30,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Rasheed Isle 1641", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/765.jpg", "Dannie Brakus", 23, "523-951-2184" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 31,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Hammes Rue 1477", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/25.jpg", "Remington Stanton", 29, "343-674-8092" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 32,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Jaydon Shoal 2105", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/398.jpg", "Kip Farrell", 3, "669-371-5535" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 33,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Cole Ford 130", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/88.jpg", "Nelle Bergstrom", 36, "379-931-5190" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 34,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Candice Crossing 2393", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/457.jpg", "Samir D'Amore", 8, "952-557-5775" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 35,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Charity Shoals 1419", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/772.jpg", "Ruth Lynch", 14, "541-713-2996" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 36,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Margaret Centers 300", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/653.jpg", "Jaydon Batz", 5, "627-636-3500" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 37,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Mireya Stream 2080", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1149.jpg", "Gillian Volkman", 4, "496-531-7952" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 38,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Henderson Land 2420", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1168.jpg", "Katheryn McClure", 9, "867-792-5421" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 39,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Guiseppe Harbors 322", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/567.jpg", "Adolph Goyette", 11, "468-597-8798" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 40,
                columns: new[] { "Address", "Avatar", "FullName", "LoanId", "Phone" },
                values: new object[] { "Hollie Stream 239", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/172.jpg", "Helen Boyer", 30, "244-666-9073" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 1,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 18, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4186), 18 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 2,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 20, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4499), 18 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 3,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 22, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4512), 13 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 4,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 13, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4518), 35 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 5,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 34, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4523), 3 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 6,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 39, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4528), 30 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 7,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 23, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4534), 9 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 8,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 6, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4539), 31 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 9,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 16, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4544), 35 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 10,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 29, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4554), 8 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 11,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 20, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4560), 7 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 12,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 21, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4566), 37 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 13,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 23, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4571), 4 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 14,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 17, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4576), 33 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 15,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 23, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4581), 40 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 16,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 31, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4586), 5 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 17,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 33, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4591), 25 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 18,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 20, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4596), 37 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 19,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 30, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4601), 6 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 20,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 20, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4606), 7 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 21,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 2, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4611), 1 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 22,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 39, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4616), 13 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 23,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 21, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4620), 7 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 24,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 37, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4626), 37 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 25,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 2, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4630), 23 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 26,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 20, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4635), 39 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 27,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 33, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4641), 1 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 28,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 6, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4645), 24 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 29,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 39, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4650), 40 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 30,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 3, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4655), 8 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 31,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 35, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4660), 40 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 32,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 31, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4665), 33 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 33,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 33, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4670), 12 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 34,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 35, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4675), 30 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 35,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 18, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4680), 15 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 36,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 25, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4685), 8 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 37,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 39, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4690), 40 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 38,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 4, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4695), 26 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 39,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 1, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4700), 25 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 40,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 4, new DateTime(2022, 9, 22, 12, 45, 47, 613, DateTimeKind.Local).AddTicks(4705), 19 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 29 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "LoanId",
                value: 37);

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
                column: "LoanId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                column: "LoanId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                column: "LoanId",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 7 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 14 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 4, 12 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 26 });

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
                column: "LoanId",
                value: 18);

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
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 40 });

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
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 1 });

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
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 20 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 23,
                column: "LoanId",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 24,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 16 });

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
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 27,
                column: "LoanId",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 28,
                column: "LoanId",
                value: 8);

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

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 31,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 16 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 32,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 32 });

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
                values: new object[] { 3, 28 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 35,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 36,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 37,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 15 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 38,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 2, 36 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 39,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 7 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 40,
                columns: new[] { "Amount", "LoanId" },
                values: new object[] { 1, 27 });

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

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 31,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Corine Parkways 2148", "Zander Schmeler", 10, "688-211-7595" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 32,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Assunta Curve 1458", "Jaiden Rogahn", 1, "338-517-2524" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 33,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Kihn Glen 2256", "Jonathan Kuphal", 9, "720-732-1334" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 34,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Mireille Point 725", "Jedediah Herman", 11, "517-661-5400" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 35,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Kuhlman Bypass 2146", "Mandy Corwin", 37, "376-270-6080" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 36,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Ledner Freeway 36", "Barton DuBuque", 16, "631-504-7449" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 37,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Windler Shoal 1144", "Daisha Sanford", 33, "286-330-6725" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 38,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Rogahn Passage 13", "Vallie Upton", 16, "487-760-0080" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 39,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Ellie Pines 1671", "Eli Runolfsson", 38, "649-805-3654" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 40,
                columns: new[] { "Address", "FullName", "LoanId", "Phone" },
                values: new object[] { "Hammes Inlet 1125", "Retta West", 38, "476-986-9315" });

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
                keyValue: 5,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 24, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(601), 29 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 6,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 4, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(607), 31 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 7,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 18, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(612), 2 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 8,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 33, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(618), 14 });

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
                keyValue: 12,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 3, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(638), 39 });

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
                keyValue: 15,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 33, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(654), 37 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 16,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 17, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(659), 25 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 17,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 17, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(664), 38 });

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
                keyValue: 26,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 33, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(711), 34 });

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
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 11, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(721), 28 });

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

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 31,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 16, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(737), 11 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 32,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 13, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(742), 37 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 33,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 29, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(748), 32 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 34,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 22, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(752), 18 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 35,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 13, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(758), 7 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 36,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 29, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(763), 17 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 37,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 16, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(768), 19 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 38,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 19, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(773), 14 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 39,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 23, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(778), 40 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "LoanId",
                keyValue: 40,
                columns: new[] { "BookId", "BookLoanDate", "CustomerId" },
                values: new object[] { 40, new DateTime(2022, 9, 22, 9, 38, 53, 385, DateTimeKind.Local).AddTicks(783), 5 });
        }
    }
}
