using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zakázky.Migrations
{
    /// <inheritdoc />
    public partial class M200420251040 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdressName",
                table: "AdressList",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubjectID",
                table: "AdressList",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AdressList_SubjectID",
                table: "AdressList",
                column: "SubjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_AdressList_Subject_SubjectID",
                table: "AdressList",
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

            migrationBuilder.DropIndex(
                name: "IX_AdressList_SubjectID",
                table: "AdressList");

            migrationBuilder.DropColumn(
                name: "AdressName",
                table: "AdressList");

            migrationBuilder.DropColumn(
                name: "SubjectID",
                table: "AdressList");
        }
    }
}
