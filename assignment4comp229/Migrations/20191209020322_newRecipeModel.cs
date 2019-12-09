using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace assignment4comp229.Migrations
{
    public partial class newRecipeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "Recipes",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Icon",
                table: "Recipes",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
