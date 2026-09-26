using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inventario.Migrations
{
    /// <inheritdoc />
    public partial class DatosSemilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Categoria", "Nombre", "Precio", "Stock" },
                values: new object[,]
                {
                    { 1, "Electrónica", "Laptop", 999.99m, 10 },
                    { 2, "Electrónica", "Smartphone", 499.99m, 3 },
                    { 3, "Muebles", "Mesa de Oficina", 199.00m, 15 },
                    { 4, "Muebles", "Silla Ergonómica", 149.99m, 2 },
                    { 5, "Electrónica", "Mouse Ergonómico", 700.00m, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
