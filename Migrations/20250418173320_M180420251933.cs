using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zakázky.Migrations
{
    /// <inheritdoc />
    public partial class M180420251933 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Employee_EmployeeTookOverId",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "EmployeeTookOverId",
                table: "Order",
                newName: "EmployeeTookOverID");

            migrationBuilder.RenameIndex(
                name: "IX_Order_EmployeeTookOverId",
                table: "Order",
                newName: "IX_Order_EmployeeTookOverID");

            migrationBuilder.CreateTable(
                name: "BindingSubjectToAdress",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectId = table.Column<int>(type: "int", nullable: true),
                    AdressId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BindingSubjectToAdress", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BindingSubjectToContact",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectId = table.Column<int>(type: "int", nullable: true),
                    ContactId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BindingSubjectToContact", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Employee_EmployeeTookOverID",
                table: "Order",
                column: "EmployeeTookOverID",
                principalTable: "Employee",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Employee_EmployeeTookOverID",
                table: "Order");

            migrationBuilder.DropTable(
                name: "BindingSubjectToAdress");

            migrationBuilder.DropTable(
                name: "BindingSubjectToContact");

            migrationBuilder.RenameColumn(
                name: "EmployeeTookOverID",
                table: "Order",
                newName: "EmployeeTookOverId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_EmployeeTookOverID",
                table: "Order",
                newName: "IX_Order_EmployeeTookOverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Employee_EmployeeTookOverId",
                table: "Order",
                column: "EmployeeTookOverId",
                principalTable: "Employee",
                principalColumn: "Id");
        }
    }
}
