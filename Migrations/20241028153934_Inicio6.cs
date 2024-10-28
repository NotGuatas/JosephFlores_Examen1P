using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JosephFlores_Examen1P.Migrations
{
    /// <inheritdoc />
    public partial class Inicio6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WheyProtein",
                table: "JF_Proteina",
                newName: "JFWheyProtein");

            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "JF_Proteina",
                newName: "JFPrecio");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "JF_Proteina",
                newName: "JFName");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "JF_Proteina",
                newName: "JFDate");

            migrationBuilder.RenameColumn(
                name: "ProteinaId",
                table: "JF_Proteina",
                newName: "JFProteinaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JFWheyProtein",
                table: "JF_Proteina",
                newName: "WheyProtein");

            migrationBuilder.RenameColumn(
                name: "JFPrecio",
                table: "JF_Proteina",
                newName: "Precio");

            migrationBuilder.RenameColumn(
                name: "JFName",
                table: "JF_Proteina",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "JFDate",
                table: "JF_Proteina",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "JFProteinaId",
                table: "JF_Proteina",
                newName: "ProteinaId");
        }
    }
}
