using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VarlıkZimmetDepoYonetimi.UI.Migrations
{
    /// <inheritdoc />
    public partial class güncelleme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CalisanAdi",
                table: "Zimmet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ekip",
                table: "Zimmet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CalisanAdi",
                table: "Zimmet");

            migrationBuilder.DropColumn(
                name: "Ekip",
                table: "Zimmet");
        }
    }
}
