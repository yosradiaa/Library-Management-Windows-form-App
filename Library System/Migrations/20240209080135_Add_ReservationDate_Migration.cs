using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library_System.Migrations
{
    /// <inheritdoc />
    public partial class Add_ReservationDate_Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ReservationDate",
                table: "PatronReserveBook",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReservationDate",
                table: "PatronReserveBook");
        }
    }
}
