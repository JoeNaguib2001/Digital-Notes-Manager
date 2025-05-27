using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Digital_Notes_Manager.Migrations
{
    /// <inheritdoc />
    public partial class AddNoteEntitySeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "ID", "Category", "Content", "CreationDate", "ReminderDate", "Title", "UserID" },
                values: new object[] { 1, 16, "Welcome to my first note", new DateTime(2025, 5, 28, 0, 37, 20, 217, DateTimeKind.Local).AddTicks(2119), new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hello", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
