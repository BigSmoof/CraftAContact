using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CraftAContact.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewSeedDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                columns: new[] { "CategoryId", "DateCreated", "Email", "FirstName", "LastName" },
                values: new object[] { 4, new DateTime(2023, 11, 24, 11, 24, 11, 0, DateTimeKind.Unspecified), "freddyfaz@gmail.com", "Mike", "Afton" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CategoryId", "DateCreated", "Email", "FirstName", "LastName", "PhoneNumber", "Username" },
                values: new object[] { 1, 2, new DateTime(2023, 11, 29, 15, 20, 32, 0, DateTimeKind.Unspecified), "imBatman222@gmail.com", "Bruce", "Wayne", 5066885555L, "Biggy1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                columns: new[] { "CategoryId", "DateCreated", "Email", "FirstName", "LastName" },
                values: new object[] { 2, new DateTime(2023, 11, 29, 15, 20, 32, 0, DateTimeKind.Unspecified), "imBatman222@gmail.com", "Bruce", "Wayne" });
        }
    }
}
