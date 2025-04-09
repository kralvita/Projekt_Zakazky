using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zakázky.Migrations
{
    /// <inheritdoc />
    public partial class M090420252351 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderID",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_OrderID",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "OrderItem");

            migrationBuilder.AddColumn<int>(
                name: "OrderItemID",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderItemID",
                table: "Order",
                column: "OrderItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_OrderItem_OrderItemID",
                table: "Order",
                column: "OrderItemID",
                principalTable: "OrderItem",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_OrderItem_OrderItemID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_OrderItemID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "OrderItemID",
                table: "Order");

            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "OrderItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderID",
                table: "OrderItem",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_OrderID",
                table: "OrderItem",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
