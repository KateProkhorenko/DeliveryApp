using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeliveryApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOrder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenderCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenderAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecipientCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecipientAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CargoWeight = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
