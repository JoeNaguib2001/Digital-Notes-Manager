using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Digital_Notes_Manager.Migrations
{
    /// <inheritdoc />
    public partial class AddUserEntitySeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Password", "Username" },
                values: new object[] { 1, "123", "Samuel" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1);
        }
    }
}
