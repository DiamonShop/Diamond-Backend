using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diamond.Entities.Migrations
{
    /// <inheritdoc />
    public partial class DiamondStore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certificates");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    CertificationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiamondID = table.Column<int>(type: "int", nullable: false),
                    CertificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CertificationDetails = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.CertificationID);
                    table.ForeignKey(
                        name: "FK_Certificates_Diamonds_DiamondID",
                        column: x => x.DiamondID,
                        principalTable: "Diamonds",
                        principalColumn: "DiamondID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_DiamondID",
                table: "Certificates",
                column: "DiamondID",
                unique: true);
        }
    }
}
