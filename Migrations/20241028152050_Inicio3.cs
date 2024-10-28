using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JosephFlores_Examen1P.Migrations
{
    /// <inheritdoc />
    public partial class Inicio3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Promo",
                columns: table => new
                {
                    PromoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProteinaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promo", x => x.PromoId);
                    table.ForeignKey(
                        name: "FK_Promo_JF_Proteina_ProteinaId",
                        column: x => x.ProteinaId,
                        principalTable: "JF_Proteina",
                        principalColumn: "ProteinaId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Promo_ProteinaId",
                table: "Promo",
                column: "ProteinaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Promo");
        }
    }
}
