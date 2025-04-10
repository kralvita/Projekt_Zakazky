using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zakázky.Migrations
{
    /// <inheritdoc />
    public partial class M100420252255 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderType",
                table: "Order",
                newName: "orderType");

            migrationBuilder.AlterColumn<int>(
                name: "orderType",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "orderState",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "orderState",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "orderType",
                table: "Order",
                newName: "OrderType");

            migrationBuilder.AlterColumn<string>(
                name: "OrderType",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
