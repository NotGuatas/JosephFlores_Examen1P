using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JosephFlores_Examen1P.Migrations
{
    /// <inheritdoc />
    public partial class Inicio5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Promo_JF_Proteina_ProteinaId",
                table: "Promo");

            migrationBuilder.RenameColumn(
                name: "ProteinaId",
                table: "Promo",
                newName: "ProteinaID");

            migrationBuilder.RenameIndex(
                name: "IX_Promo_ProteinaId",
                table: "Promo",
                newName: "IX_Promo_ProteinaID");

            migrationBuilder.AlterColumn<int>(
                name: "ProteinaID",
                table: "Promo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Promo_JF_Proteina_ProteinaID",
                table: "Promo",
                column: "ProteinaID",
                principalTable: "JF_Proteina",
                principalColumn: "ProteinaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Promo_JF_Proteina_ProteinaID",
                table: "Promo");

            migrationBuilder.RenameColumn(
                name: "ProteinaID",
                table: "Promo",
                newName: "ProteinaId");

            migrationBuilder.RenameIndex(
                name: "IX_Promo_ProteinaID",
                table: "Promo",
                newName: "IX_Promo_ProteinaId");

            migrationBuilder.AlterColumn<int>(
                name: "ProteinaId",
                table: "Promo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Promo_JF_Proteina_ProteinaId",
                table: "Promo",
                column: "ProteinaId",
                principalTable: "JF_Proteina",
                principalColumn: "ProteinaId");
        }
    }
}
