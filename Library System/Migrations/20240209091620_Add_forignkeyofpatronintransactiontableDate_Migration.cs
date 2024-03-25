using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library_System.Migrations
{
    /// <inheritdoc />
    public partial class Add_forignkeyofpatronintransactiontableDate_Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Transaction_PatronID",
                table: "Transaction",
                column: "PatronID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Patron_PatronID",
                table: "Transaction",
                column: "PatronID",
                principalTable: "Patron",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Patron_PatronID",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_PatronID",
                table: "Transaction");
        }
    }
}
