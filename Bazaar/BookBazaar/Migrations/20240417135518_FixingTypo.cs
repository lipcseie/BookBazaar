using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookBazaar.Migrations
{
    /// <inheritdoc />
    public partial class FixingTypo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DispkayOrder",
                table: "Categories",
                newName: "DisplayOrder");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DisplayOrder",
                table: "Categories",
                newName: "DispkayOrder");
        }
    }
}
