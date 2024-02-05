using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactList.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddAppUserToAttempt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUserID",
                table: "Attempts");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Attempts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Attempts_AppUserId",
                table: "Attempts",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attempts_AspNetUsers_AppUserId",
                table: "Attempts",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attempts_AspNetUsers_AppUserId",
                table: "Attempts");

            migrationBuilder.DropIndex(
                name: "IX_Attempts_AppUserId",
                table: "Attempts");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Attempts");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserID",
                table: "Attempts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
