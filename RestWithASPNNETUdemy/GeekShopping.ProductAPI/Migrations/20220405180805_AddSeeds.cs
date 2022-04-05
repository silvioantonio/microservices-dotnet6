using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class AddSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 1L, "Eletronicos", "Notebook ideapad S145 com melhor custo benêficios", "//", "Notebook 14'", 6500.59m },
                    { 2L, "Eletronicos", "Notebook ideapad S145 com melhor custo benêficios", "//", "Notebook 14'", 6500.59m },
                    { 3L, "Eletronicos", "Notebook ideapad S145 com melhor custo benêficios", "//", "Notebook 14'", 6500.59m },
                    { 4L, "Eletronicos", "Notebook ideapad S145 com melhor custo benêficios", "//", "Notebook 14'", 6500.59m },
                    { 5L, "Eletronicos", "Notebook ideapad S145 com melhor custo benêficios", "//", "Notebook 14'", 6500.59m },
                    { 6L, "Eletronicos", "Notebook ideapad S145 com melhor custo benêficios", "//", "Notebook 14'", 6500.59m },
                    { 7L, "Eletronicos", "Notebook ideapad S145 com melhor custo benêficios", "//", "Notebook 14'", 6500.59m },
                    { 8L, "Eletronicos", "Notebook ideapad S145 com melhor custo benêficios", "//", "Notebook 14'", 6500.59m },
                    { 9L, "Eletronicos", "Notebook ideapad S145 com melhor custo benêficios", "//", "Notebook 14'", 6500.59m },
                    { 10L, "Eletronicos", "Notebook ideapad S145 com melhor custo benêficios", "//", "Notebook 14'", 6500.59m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 10L);
        }
    }
}
