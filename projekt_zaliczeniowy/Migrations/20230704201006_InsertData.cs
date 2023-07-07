using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projekt_zaliczeniowy.Migrations
{
    /// <inheritdoc />
    public partial class InsertData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Ingredient (Name, Description, Protein, Fat, Carbohydrates, Quantity, RecipeId, Definition) VALUES ('Wolowina', '', 26, 15, 0, 0, null, 1);", false);
            migrationBuilder.Sql("INSERT INTO Ingredient (Name, Description, Protein, Fat, Carbohydrates, Quantity, RecipeId, Definition) VALUES ('Kurczak', '', 27, 14, 0, 0, null, 1);", false);
            migrationBuilder.Sql("INSERT INTO Ingredient (Name, Description, Protein, Fat, Carbohydrates, Quantity, RecipeId, Definition) VALUES ('Jagniecina', '', 25, 21, 0, 0, null, 1 );", false);
            migrationBuilder.Sql("INSERT INTO Ingredient (Name, Description, Protein, Fat, Carbohydrates, Quantity, RecipeId, Definition) VALUES ('Dziczyzna', '', 22.2, 1.6, 0, 0, null, 1);", false);
            migrationBuilder.Sql("INSERT INTO Ingredient (Name, Description, Protein, Fat, Carbohydrates, Quantity, RecipeId, Definition) VALUES ('Zyto', '', 10.34, 1.63, 75.86, 0, null, 1);", false);
            migrationBuilder.Sql("INSERT INTO Ingredient (Name, Description, Protein, Fat, Carbohydrates, Quantity, RecipeId, Definition) VALUES ('Przenica', '', 10.69, 1.99, 75.4, 0, null, 1);", false);
            migrationBuilder.Sql("INSERT INTO Ingredient (Name, Description, Protein, Fat, Carbohydrates, Quantity, RecipeId, Definition) VALUES ('Jablko', '', 0.3, 0.2, 14, 0, null, 1  );", false);
            migrationBuilder.Sql("INSERT INTO Ingredient (Name, Description, Protein, Fat, Carbohydrates, Quantity, RecipeId, Definition) VALUES ('Gruszka', '', 0.4, 0.1, 15, 0, null, 1);", false);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Ingredient", false);

        }
    }
}
