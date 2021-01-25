using Microsoft.EntityFrameworkCore.Migrations;

namespace VendasWeb.Migrations
{
    public partial class DepartmentoForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendedor_Departamento_DerpartamentoId",
                table: "Vendedor");

            migrationBuilder.DropIndex(
                name: "IX_Vendedor_DerpartamentoId",
                table: "Vendedor");

            migrationBuilder.DropColumn(
                name: "DerpartamentoId",
                table: "Vendedor");

            migrationBuilder.AddColumn<int>(
                name: "DepartamentoId",
                table: "Vendedor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vendedor_DepartamentoId",
                table: "Vendedor",
                column: "DepartamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedor_Departamento_DepartamentoId",
                table: "Vendedor",
                column: "DepartamentoId",
                principalTable: "Departamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendedor_Departamento_DepartamentoId",
                table: "Vendedor");

            migrationBuilder.DropIndex(
                name: "IX_Vendedor_DepartamentoId",
                table: "Vendedor");

            migrationBuilder.DropColumn(
                name: "DepartamentoId",
                table: "Vendedor");

            migrationBuilder.AddColumn<int>(
                name: "DerpartamentoId",
                table: "Vendedor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vendedor_DerpartamentoId",
                table: "Vendedor",
                column: "DerpartamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedor_Departamento_DerpartamentoId",
                table: "Vendedor",
                column: "DerpartamentoId",
                principalTable: "Departamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
