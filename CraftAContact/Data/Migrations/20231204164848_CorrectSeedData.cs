using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CraftAContact.Data.Migrations
{
    /// <inheritdoc />
    public partial class CorrectSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "Email",
                value: "kiryuChan11@msn.com");

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CategoryId", "DateCreated", "Email", "FirstName", "LastName", "PhoneNumber", "Username" },
                values: new object[] { 3, 2, new DateTime(2023, 11, 29, 15, 20, 32, 0, DateTimeKind.Unspecified), "imBatman222@gmail.com", "Bruce", "Wayne", 5066885555L, "Biggy1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "Email",
                value: "kiryuChan23@msn.com");

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CategoryId", "DateCreated", "Email", "FirstName", "LastName", "PhoneNumber", "Username" },
                values: new object[] { 1, 2, new DateTime(2023, 11, 29, 15, 20, 32, 0, DateTimeKind.Unspecified), "imBatman222@gmail.com", "Bruce", "Wayne", 5066885555L, "Biggy1" });
        }
    }
}
