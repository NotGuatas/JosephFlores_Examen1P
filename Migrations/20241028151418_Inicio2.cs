using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JosephFlores_Examen1P.Migrations
{
    /// <inheritdoc />
    public partial class Inicio2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "WheyProtein",
                table: "JF_Proteina",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "WheyProtein",
                table: "JF_Proteina",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
