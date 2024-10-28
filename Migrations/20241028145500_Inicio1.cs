using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JosephFlores_Examen1P.Migrations
{
    /// <inheritdoc />
    public partial class Inicio1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JF_Proteina",
                columns: table => new
                {
                    ProteinaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WheyProtein = table.Column<bool>(type: "bit", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JF_Proteina", x => x.ProteinaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JF_Proteina");
        }
    }
}
