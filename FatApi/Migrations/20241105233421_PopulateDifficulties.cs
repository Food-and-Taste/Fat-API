using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FatApi.Migrations
{
    /// <inheritdoc />
    public partial class PopulateDifficulties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Difficulties (Difficulty) VALUES ('Easy'), ('Medium'), ('Hard'), ('Extreme')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE Difficulties");
        }
    }
}