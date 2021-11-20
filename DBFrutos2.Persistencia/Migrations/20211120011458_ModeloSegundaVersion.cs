using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBFrutos2.Persistencia.Migrations
{
    public partial class ModeloSegundaVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Pedidos_PedidoId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventarios_Productos_ProductoId",
                table: "Inventarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_TiposUsuario_TipousuarioId",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "TiposUsuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_TipousuarioId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Inventarios_ProductoId",
                table: "Inventarios");

            migrationBuilder.RenameColumn(
                name: "TipousuarioId",
                table: "Usuarios",
                newName: "tipoUsuario");

            migrationBuilder.RenameColumn(
                name: "ProductoId",
                table: "Inventarios",
                newName: "Peso");

            migrationBuilder.RenameColumn(
                name: "PedidoId",
                table: "Facturas",
                newName: "pedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_Facturas_PedidoId",
                table: "Facturas",
                newName: "IX_Facturas_pedidoId");

            migrationBuilder.AlterColumn<float>(
                name: "Valor_Declarado",
                table: "Pedidos",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<float>(
                name: "Valor",
                table: "Pedidos",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

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

            migrationBuilder.AddColumn<string>(
                name: "Marca",
                table: "Inventarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Inventarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "Valor",
                table: "Inventarios",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateTable(
                name: "SolicitudesPedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PedidoId = table.Column<int>(type: "int", nullable: false),
                    inventarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudesPedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitudesPedidos_Inventarios_inventarioId",
                        column: x => x.inventarioId,
                        principalTable: "Inventarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolicitudesPedidos_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_inventarioId",
                table: "Pedidos",
                column: "inventarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_usuarioId",
                table: "Pedidos",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudesPedidos_inventarioId",
                table: "SolicitudesPedidos",
                column: "inventarioId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudesPedidos_PedidoId",
                table: "SolicitudesPedidos",
                column: "PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_SolicitudesPedidos_pedidoId",
                table: "Facturas",
                column: "pedidoId",
                principalTable: "SolicitudesPedidos",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_SolicitudesPedidos_pedidoId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Inventarios_inventarioId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Usuarios_usuarioId",
                table: "Pedidos");

            migrationBuilder.DropTable(
                name: "SolicitudesPedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_inventarioId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_usuarioId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "inventarioId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "usuarioId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Marca",
                table: "Inventarios");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Inventarios");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Inventarios");

            migrationBuilder.RenameColumn(
                name: "tipoUsuario",
                table: "Usuarios",
                newName: "TipousuarioId");

            migrationBuilder.RenameColumn(
                name: "Peso",
                table: "Inventarios",
                newName: "ProductoId");

            migrationBuilder.RenameColumn(
                name: "pedidoId",
                table: "Facturas",
                newName: "PedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_Facturas_pedidoId",
                table: "Facturas",
                newName: "IX_Facturas_PedidoId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Valor_Declarado",
                table: "Pedidos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "Pedidos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposUsuario", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_TipousuarioId",
                table: "Usuarios",
                column: "TipousuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventarios_ProductoId",
                table: "Inventarios",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Pedidos_PedidoId",
                table: "Facturas",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventarios_Productos_ProductoId",
                table: "Inventarios",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_TiposUsuario_TipousuarioId",
                table: "Usuarios",
                column: "TipousuarioId",
                principalTable: "TiposUsuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
