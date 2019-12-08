using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace assignment4comp229.Migrations
{
    public partial class sd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Rating = table.Column<double>(nullable: false),
                    RecipeId = table.Column<int>(nullable: false),
                    RecipeReview = table.Column<string>(nullable: true),
                    UserPosted = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Ingredients = table.Column<string>(nullable: true),
                    Icon = table.Column<byte[]>(nullable: true),
                    Time = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    EditDate = table.Column<DateTime>(nullable: true),
                    ReviewId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeId);
                    table.ForeignKey(
                        name: "FK_Recipes_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "ReviewId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "Description", "EditDate", "Icon", "Ingredients", "Name", "ReviewId", "Time", "UserName" },
                values: new object[] { 1, "Simple apple pie", null, null, "6 cups sliced apples, 3/4 cup white sugar, 1tbsp butter, 1tsp cinnamon, 1 pastry", "Apple Pie", null, "1 hour", "Default User" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "Description", "EditDate", "Icon", "Ingredients", "Name", "ReviewId", "Time", "UserName" },
                values: new object[] { 2, "Quick and simple, but delicious!", null, null, "2tbsp olive oil, 1 chopped onion, chicken breast, 3tbsp ketchup, 2tbsp soy sauce, 2tbsp lemon juice, 1tsp black pepper", "Simple Chicken Dish", null, "35 minutes", "Default User" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Rating", "RecipeId", "RecipeReview", "UserPosted" },
                values: new object[,]
                {
                    { 1058, 4.0, 1, "It was alright.", null },
                    { 1059, 4.5, 1, "Delicious, but basic.", null },
                    { 60, 5.0, 2, "Amazing!", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_ReviewId",
                table: "Recipes",
                column: "ReviewId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
