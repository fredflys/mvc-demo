using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mvc_demo.Migrations
{
    /// <inheritdoc />
    public partial class AddPhotoName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "Items",
                newName: "Image");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Items",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Items",
                newName: "Photo");
        }
    }
}
