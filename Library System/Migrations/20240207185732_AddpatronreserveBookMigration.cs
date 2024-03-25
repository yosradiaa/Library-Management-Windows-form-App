using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library_System.Migrations
{
    /// <inheritdoc />
    public partial class AddpatronreserveBookMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookPatron");

            migrationBuilder.CreateTable(
                name: "PatronReserveBook",
                columns: table => new
                {
                    ISBN = table.Column<long>(type: "bigint", nullable: false),
                    PatronID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatronReserveBook", x => new { x.ISBN, x.PatronID });
                    table.ForeignKey(
                        name: "FK_PatronReserveBook_Book_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Book",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatronReserveBook_Patron_PatronID",
                        column: x => x.PatronID,
                        principalTable: "Patron",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatronReserveBook_PatronID",
                table: "PatronReserveBook",
                column: "PatronID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatronReserveBook");

            migrationBuilder.CreateTable(
                name: "BookPatron",
                columns: table => new
                {
                    BooksISBN = table.Column<long>(type: "bigint", nullable: false),
                    PatronId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookPatron", x => new { x.BooksISBN, x.PatronId });
                    table.ForeignKey(
                        name: "FK_BookPatron_Book_BooksISBN",
                        column: x => x.BooksISBN,
                        principalTable: "Book",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookPatron_Patron_PatronId",
                        column: x => x.PatronId,
                        principalTable: "Patron",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookPatron_PatronId",
                table: "BookPatron",
                column: "PatronId");
        }
    }
}
