using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMarket.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AdaptProductModelForTech : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ISBN",
                table: "Products",
                newName: "ModelNumber");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Products",
                newName: "Brand");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Graphics Cards");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Processors");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Monitors");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[] { "Silicon Valley", "Apex Innovations", "8005550101", "94043", "CA", "123 Innovation Dr" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[] { "Austin", "CircuitWorks", "8005550102", "78701", "TX", "456 Component Ave" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[] { "Seattle", "Digital Horizon", "8005550103", "98101", "WA", "789 Pixel Blvd" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "Description", "ListPrice", "ModelNumber", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Apex Innovations", "Experience next-generation gaming with hyper-realistic ray tracing and AI-powered performance boosts. The flagship GPU for enthusiasts.", 1299.0, "APX-NV-5080", 1199.0, 1099.0, 1149.0, "Apex Nova RTX 5080" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand", "Description", "ListPrice", "ModelNumber", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "CircuitWorks", "A powerful competitor offering incredible 4K performance and high refresh rates. Built on a revolutionary new architecture.", 999.0, "CW-PL-9800XT", 949.0, 849.0, 899.0, "CircuitWorks Pulse RX 9800XT" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brand", "CategoryId", "Description", "ListPrice", "ModelNumber", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Apex Innovations", 2, "Unleash extreme mega-tasking performance with 16 cores and 24 threads. The ultimate CPU for content creation and hardcore gaming.", 649.0, "APX-CPU-i9U", 629.0, 579.0, 599.0, "Apex Core i9 Ultra" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brand", "Description", "ListPrice", "ModelNumber", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Digital Horizon", "Dominate your workload with this efficient and powerful processor. Perfect for streamers, creators, and professionals.", 599.0, "DH-RYZ-9X", 579.0, 529.0, 549.0, "Digital Horizon Ryzen 9" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Brand", "CategoryId", "Description", "ListPrice", "ModelNumber", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Digital Horizon", 3, "A professional 32-inch 4K HDR monitor with exceptional color accuracy. Designed for photographers, videographers, and graphic designers.", 899.0, "DH-MON-PA32K", 849.0, 799.0, 829.0, "Digital Horizon ProArt 32\" 4K" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Brand", "Description", "ListPrice", "ModelNumber", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "CircuitWorks", "Gain the competitive edge with a blazing-fast 240Hz refresh rate and a crisp QHD resolution. Smooth, tear-free gaming has arrived.", 449.0, "CW-MON-GM27Q", 429.0, 379.0, 399.0, "CircuitWorks Gaming 27\" QHD 240Hz" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModelNumber",
                table: "Products",
                newName: "ISBN");

            migrationBuilder.RenameColumn(
                name: "Brand",
                table: "Products",
                newName: "Author");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Action");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "SciFi");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "History");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[] { "Tech City", "Tech Solution", "6669990000", "12121", "IL", "123 Tech St" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[] { "Vid City", "Vivid Books", "7779990000", "66666", "IL", "999 Vid St" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[] { "Lala land", "Readers Club", "1113335555", "99999", "NY", "999 Main St" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Billy Spark", "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SWD9999001", 99.0, 90.0, 80.0, 85.0, "Fortune of Time" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Nancy Hoover", "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "CAW777777701", 40.0, 30.0, 20.0, 25.0, "Dark Skies" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "CategoryId", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Julian Button", 1, "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "RITO5555501", 55.0, 50.0, 35.0, 40.0, "Vanish in the Sunset" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Abby Muscles", "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "WS3333333301", 70.0, 65.0, 55.0, 60.0, "Cotton Candy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "CategoryId", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Ron Parker", 2, "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SOTJ1111111101", 30.0, 27.0, 20.0, 25.0, "Rock in the Ocean" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Laura Phantom", "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "FOT000000001", 25.0, 23.0, 20.0, 22.0, "Leaves and Wonders" });
        }
    }
}
