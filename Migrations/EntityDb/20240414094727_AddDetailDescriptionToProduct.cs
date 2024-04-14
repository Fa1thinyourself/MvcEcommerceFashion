using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcEcommerceFashion.Migrations.EntityDb
{
    /// <inheritdoc />
    public partial class AddDetailDescriptionToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DetailDescription",
                table: "Product",
                type: "nvarchar(2000)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetailDescription",
                table: "Product");
        }
    }
}
