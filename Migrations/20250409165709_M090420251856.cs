using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zakázky.Migrations
{
    /// <inheritdoc />
    public partial class M090420251856 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContractorID",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_ContractorID",
                table: "Order",
                column: "ContractorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Subject_ContractorID",
                table: "Order",
                column: "ContractorID",
                principalTable: "Subject",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Subject_ContractorID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_ContractorID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ContractorID",
                table: "Order");
        }
    }
}
