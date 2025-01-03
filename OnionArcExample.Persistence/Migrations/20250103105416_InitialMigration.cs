using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnionArcExample.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("0a840032-c3e6-4981-b49d-1c66df5c3ccc"), "Product 1 Description", "Product 1", 1000, 10 },
                    { new Guid("387b2bdf-787a-4777-9d4d-f63e0c6c16e6"), "Product 3 Description", "Product 3", 3000, 30 },
                    { new Guid("a124d6ae-4493-4e67-9b50-c633ccc076e8"), "Product 2 Description", "Product 2", 2000, 20 },
                    { new Guid("e1dc46a0-1a05-4c66-84aa-bc1e8d749a5b"), "Product 4 Description", "Product 4", 4000, 40 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
