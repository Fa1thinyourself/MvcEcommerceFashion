using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcEcommerceFashion.Migrations.EntityDb
{
    /// <inheritdoc />
    public partial class AddTagToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tag",
                table: "Product",
                type: "nvarchar(256)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tag",
                table: "Product");
        }
    }
}
