using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaMIzza.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableSizes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PizzaId",
                table: "Sizes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sizes_PizzaId",
                table: "Sizes",
                column: "PizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sizes_Pizzas_PizzaId",
                table: "Sizes",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sizes_Pizzas_PizzaId",
                table: "Sizes");

            migrationBuilder.DropIndex(
                name: "IX_Sizes_PizzaId",
                table: "Sizes");

            migrationBuilder.DropColumn(
                name: "PizzaId",
                table: "Sizes");
        }
    }
}
