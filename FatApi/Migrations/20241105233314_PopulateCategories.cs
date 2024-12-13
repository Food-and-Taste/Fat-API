using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FatApi.Migrations
{
    /// <inheritdoc />
    public partial class PopulateCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories (Category) VALUES ('Meal'), ('Dessert'), ('Drink')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE Categories");
        }
    }
}