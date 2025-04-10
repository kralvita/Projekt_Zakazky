using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zakázky.Migrations
{
    /// <inheritdoc />
    public partial class M100420251542 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdressList_Subject_SubjectID",
                table: "AdressList");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactList_Subject_SubjectID",
                table: "ContactList");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_ContactList_ContactID",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_ContactList_SubjectID",
                table: "ContactList");

            migrationBuilder.DropIndex(
                name: "IX_AdressList_SubjectID",
                table: "AdressList");

            migrationBuilder.DropColumn(
                name: "SubjectID",
                table: "ContactList");

            migrationBuilder.DropColumn(
                name: "SubjectID",
                table: "AdressList");

            migrationBuilder.RenameColumn(
                name: "ContactID",
                table: "Employee",
                newName: "ContactId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_ContactID",
                table: "Employee",
                newName: "IX_Employee_ContactId");

            migrationBuilder.AddColumn<int>(
                name: "AdressListID",
                table: "Subject",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContactListID",
                table: "Subject",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subject_AdressListID",
                table: "Subject",
                column: "AdressListID");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_ContactListID",
                table: "Subject",
                column: "ContactListID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_ContactList_ContactId",
                table: "Employee",
                column: "ContactId",
                principalTable: "ContactList",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_AdressList_AdressListID",
                table: "Subject",
                column: "AdressListID",
                principalTable: "AdressList",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_ContactList_ContactListID",
                table: "Subject",
                column: "ContactListID",
                principalTable: "ContactList",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_ContactList_ContactId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_AdressList_AdressListID",
                table: "Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_ContactList_ContactListID",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_AdressListID",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_ContactListID",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "AdressListID",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "ContactListID",
                table: "Subject");

            migrationBuilder.RenameColumn(
                name: "ContactId",
                table: "Employee",
                newName: "ContactID");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_ContactId",
                table: "Employee",
                newName: "IX_Employee_ContactID");

            migrationBuilder.AddColumn<int>(
                name: "SubjectID",
                table: "ContactList",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubjectID",
                table: "AdressList",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactList_SubjectID",
                table: "ContactList",
                column: "SubjectID",
                unique: true,
                filter: "[SubjectID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AdressList_SubjectID",
                table: "AdressList",
                column: "SubjectID",
                unique: true,
                filter: "[SubjectID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AdressList_Subject_SubjectID",
                table: "AdressList",
                column: "SubjectID",
                principalTable: "Subject",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactList_Subject_SubjectID",
                table: "ContactList",
                column: "SubjectID",
                principalTable: "Subject",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_ContactList_ContactID",
                table: "Employee",
                column: "ContactID",
                principalTable: "ContactList",
                principalColumn: "ID");
        }
    }
}
