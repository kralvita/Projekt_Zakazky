using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zakázky.Migrations
{
    /// <inheritdoc />
    public partial class M090420252255 : Migration
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

            migrationBuilder.DropIndex(
                name: "IX_ContactList_SubjectID",
                table: "ContactList");

            migrationBuilder.DropIndex(
                name: "IX_AdressList_SubjectID",
                table: "AdressList");

            migrationBuilder.AlterColumn<int>(
                name: "SubjectID",
                table: "ContactList",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SubjectID",
                table: "AdressList",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdressList_Subject_SubjectID",
                table: "AdressList");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactList_Subject_SubjectID",
                table: "ContactList");

            migrationBuilder.DropIndex(
                name: "IX_ContactList_SubjectID",
                table: "ContactList");

            migrationBuilder.DropIndex(
                name: "IX_AdressList_SubjectID",
                table: "AdressList");

            migrationBuilder.AlterColumn<int>(
                name: "SubjectID",
                table: "ContactList",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SubjectID",
                table: "AdressList",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactList_SubjectID",
                table: "ContactList",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_AdressList_SubjectID",
                table: "AdressList",
                column: "SubjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_AdressList_Subject_SubjectID",
                table: "AdressList",
                column: "SubjectID",
                principalTable: "Subject",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactList_Subject_SubjectID",
                table: "ContactList",
                column: "SubjectID",
                principalTable: "Subject",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
