using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StreamingTools.Migrations
{
    /// <inheritdoc />
    public partial class AddSharedLinksColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SharedLinks",
                table: "Videos",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SharedLinks",
                table: "Videos");
        }
    }
}
