using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CraftAContact.Data.Migrations
{
    /// <inheritdoc />
    public partial class ReadjustSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: -1);

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CategoryId", "DateCreated", "Email", "FirstName", "LastName", "PhoneNumber", "Username" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2023, 11, 29, 15, 20, 32, 0, DateTimeKind.Unspecified), "imBatman222@gmail.com", "Bruce", "Wayne", 5066885555L, "Biggy1" },
                    { 2, 1, new DateTime(2023, 11, 27, 12, 14, 12, 0, DateTimeKind.Unspecified), "kiryuChan11@msn.com", "Goro", "Majima", 5064779584L, "Biggy1" },
                    { 3, 4, new DateTime(2023, 11, 24, 11, 24, 11, 0, DateTimeKind.Unspecified), "freddyfaz@gmail.com", "Mike", "Afton", 5066885555L, "Biggy1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CategoryId", "DateCreated", "Email", "FirstName", "LastName", "PhoneNumber", "Username" },
                values: new object[,]
                {
                    { -3, 4, new DateTime(2023, 11, 24, 11, 24, 11, 0, DateTimeKind.Unspecified), "freddyfaz@gmail.com", "Mike", "Afton", 5066885555L, "Biggy1" },
                    { -2, 1, new DateTime(2023, 11, 27, 12, 14, 12, 0, DateTimeKind.Unspecified), "kiryuChan11@msn.com", "Goro", "Majima", 5064779584L, "Biggy1" },
                    { -1, 2, new DateTime(2023, 11, 29, 15, 20, 32, 0, DateTimeKind.Unspecified), "imBatman222@gmail.com", "Bruce", "Wayne", 5066885555L, "Biggy1" }
                });
        }
    }
}
