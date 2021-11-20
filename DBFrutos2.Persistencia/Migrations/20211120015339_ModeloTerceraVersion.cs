using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBFrutos2.Persistencia.Migrations
{
    public partial class ModeloTerceraVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Usuarios_UsuarioId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Inventarios_inventarioId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Usuarios_usuarioId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_inventarioId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_usuarioId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Facturas_UsuarioId",
                table: "Facturas");

            migrationBuilder.DropColumn(
                name: "inventarioId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "usuarioId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Facturas");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "Pedidos",
                newName: "ValorVenta");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "Inventarios",
                newName: "ValorProducto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ValorVenta",
                table: "Pedidos",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "ValorProducto",
                table: "Inventarios",
                newName: "Valor");

            migrationBuilder.AddColumn<int>(
                name: "inventarioId",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "usuarioId",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Facturas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_inventarioId",
                table: "Pedidos",
                column: "inventarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_usuarioId",
                table: "Pedidos",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_UsuarioId",
                table: "Facturas",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Usuarios_UsuarioId",
                table: "Facturas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Inventarios_inventarioId",
                table: "Pedidos",
                column: "inventarioId",
                principalTable: "Inventarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Usuarios_usuarioId",
                table: "Pedidos",
                column: "usuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
