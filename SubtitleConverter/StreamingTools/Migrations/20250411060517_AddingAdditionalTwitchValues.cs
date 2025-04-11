using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StreamingTools.Migrations
{
    /// <inheritdoc />
    public partial class AddingAdditionalTwitchValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TwitchDescription",
                table: "Videos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TwitchTitle",
                table: "Videos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TwitchUrl",
                table: "Videos",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TwitchDescription",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "TwitchTitle",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "TwitchUrl",
                table: "Videos");
        }
    }
}
