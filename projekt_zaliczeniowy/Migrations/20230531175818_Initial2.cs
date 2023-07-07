using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projekt_zaliczeniowy.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Quantity",
                table: "Ingredient",
                type: "decimal(16,4)",
                precision: 16,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Protein",
                table: "Ingredient",
                type: "decimal(16,4)",
                precision: 16,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Fat",
                table: "Ingredient",
                type: "decimal(16,4)",
                precision: 16,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Carbohydrates",
                table: "Ingredient",
                type: "decimal(16,4)",
                precision: 16,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Quantity",
                table: "Ingredient",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(16,4)",
                oldPrecision: 16,
                oldScale: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "Protein",
                table: "Ingredient",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(16,4)",
                oldPrecision: 16,
                oldScale: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "Fat",
                table: "Ingredient",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(16,4)",
                oldPrecision: 16,
                oldScale: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "Carbohydrates",
                table: "Ingredient",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(16,4)",
                oldPrecision: 16,
                oldScale: 4);
        }
    }
}
