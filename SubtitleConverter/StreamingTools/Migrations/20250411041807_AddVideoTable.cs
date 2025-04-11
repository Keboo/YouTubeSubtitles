using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StreamingTools.Migrations
{
    /// <inheritdoc />
    public partial class AddVideoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TwitchStartTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    TwitchDuration = table.Column<TimeSpan>(type: "time", nullable: true),
                    TwitchId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YouTubePublishTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    YouTubeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubtitlesUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Videos");
        }
    }
}
