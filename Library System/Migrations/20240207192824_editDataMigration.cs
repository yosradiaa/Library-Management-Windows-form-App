using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library_System.Migrations
{
    /// <inheritdoc />
    public partial class editDataMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MembershiopType",
                table: "Patron");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Librarian");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Patron",
                newName: "MembershipType");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MembershipType",
                table: "Patron",
                newName: "Role");

            migrationBuilder.AddColumn<string>(
                name: "MembershiopType",
                table: "Patron",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Librarian",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
