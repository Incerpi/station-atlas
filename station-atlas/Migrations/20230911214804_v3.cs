using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace station_atlas.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_PEDIDO_TB_PAGAMENTO_IdPagamento",
                table: "TB_PEDIDO");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PEDIDO_TB_PRODUTO_IdProduto",
                table: "TB_PEDIDO");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PEDIDO_TB_USUARIO_IdUsuario",
                table: "TB_PEDIDO");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PRODUTO_TB_CATEGORIA_IdCategoria",
                table: "TB_PRODUTO");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_USUARIO_TB_ENDERECO_IdEndereco",
                table: "TB_USUARIO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_USUARIO",
                table: "TB_USUARIO");

            migrationBuilder.DropIndex(
                name: "IX_TB_USUARIO_IdEndereco",
                table: "TB_USUARIO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_PRODUTO",
                table: "TB_PRODUTO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_PEDIDO",
                table: "TB_PEDIDO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_PAGAMENTO",
                table: "TB_PAGAMENTO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_ENDERECO",
                table: "TB_ENDERECO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_CATEGORIA",
                table: "TB_CATEGORIA");

            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "TB_USUARIO");

            migrationBuilder.DropColumn(
                name: "IdEndereco",
                table: "TB_USUARIO");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "TB_USUARIO");

            migrationBuilder.RenameTable(
                name: "TB_USUARIO",
                newName: "USUARIO");

            migrationBuilder.RenameTable(
                name: "TB_PRODUTO",
                newName: "PRODUTO");

            migrationBuilder.RenameTable(
                name: "TB_PEDIDO",
                newName: "PEDIDO");

            migrationBuilder.RenameTable(
                name: "TB_PAGAMENTO",
                newName: "PAGAMENTO");

            migrationBuilder.RenameTable(
                name: "TB_ENDERECO",
                newName: "ENDERECO");

            migrationBuilder.RenameTable(
                name: "TB_CATEGORIA",
                newName: "CATEGORIA");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PRODUTO_IdCategoria",
                table: "PRODUTO",
                newName: "IX_PRODUTO_IdCategoria");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "PEDIDO",
                newName: "IdCliente");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PEDIDO_IdUsuario",
                table: "PEDIDO",
                newName: "IX_PEDIDO_IdCliente");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PEDIDO_IdProduto",
                table: "PEDIDO",
                newName: "IX_PEDIDO_IdProduto");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PEDIDO_IdPagamento",
                table: "PEDIDO",
                newName: "IX_PEDIDO_IdPagamento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_USUARIO",
                table: "USUARIO",
                column: "IdUsuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PRODUTO",
                table: "PRODUTO",
                column: "IdProduto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PEDIDO",
                table: "PEDIDO",
                column: "IdPedido");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PAGAMENTO",
                table: "PAGAMENTO",
                column: "IdPagamento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ENDERECO",
                table: "ENDERECO",
                column: "IdEndereco");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CATEGORIA",
                table: "CATEGORIA",
                column: "IdCategoria");

            migrationBuilder.CreateTable(
                name: "CLIENTE",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Sobrenome = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Cpf = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Senha = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Telefone = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    IdEndereco = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTE", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_CLIENTE_ENDERECO_IdEndereco",
                        column: x => x.IdEndereco,
                        principalTable: "ENDERECO",
                        principalColumn: "IdEndereco",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CLIENTE_IdEndereco",
                table: "CLIENTE",
                column: "IdEndereco");

            migrationBuilder.AddForeignKey(
                name: "FK_PEDIDO_CLIENTE_IdCliente",
                table: "PEDIDO",
                column: "IdCliente",
                principalTable: "CLIENTE",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PEDIDO_PAGAMENTO_IdPagamento",
                table: "PEDIDO",
                column: "IdPagamento",
                principalTable: "PAGAMENTO",
                principalColumn: "IdPagamento",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PEDIDO_PRODUTO_IdProduto",
                table: "PEDIDO",
                column: "IdProduto",
                principalTable: "PRODUTO",
                principalColumn: "IdProduto",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUTO_CATEGORIA_IdCategoria",
                table: "PRODUTO",
                column: "IdCategoria",
                principalTable: "CATEGORIA",
                principalColumn: "IdCategoria",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PEDIDO_CLIENTE_IdCliente",
                table: "PEDIDO");

            migrationBuilder.DropForeignKey(
                name: "FK_PEDIDO_PAGAMENTO_IdPagamento",
                table: "PEDIDO");

            migrationBuilder.DropForeignKey(
                name: "FK_PEDIDO_PRODUTO_IdProduto",
                table: "PEDIDO");

            migrationBuilder.DropForeignKey(
                name: "FK_PRODUTO_CATEGORIA_IdCategoria",
                table: "PRODUTO");

            migrationBuilder.DropTable(
                name: "CLIENTE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_USUARIO",
                table: "USUARIO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PRODUTO",
                table: "PRODUTO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PEDIDO",
                table: "PEDIDO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PAGAMENTO",
                table: "PAGAMENTO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ENDERECO",
                table: "ENDERECO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CATEGORIA",
                table: "CATEGORIA");

            migrationBuilder.RenameTable(
                name: "USUARIO",
                newName: "TB_USUARIO");

            migrationBuilder.RenameTable(
                name: "PRODUTO",
                newName: "TB_PRODUTO");

            migrationBuilder.RenameTable(
                name: "PEDIDO",
                newName: "TB_PEDIDO");

            migrationBuilder.RenameTable(
                name: "PAGAMENTO",
                newName: "TB_PAGAMENTO");

            migrationBuilder.RenameTable(
                name: "ENDERECO",
                newName: "TB_ENDERECO");

            migrationBuilder.RenameTable(
                name: "CATEGORIA",
                newName: "TB_CATEGORIA");

            migrationBuilder.RenameIndex(
                name: "IX_PRODUTO_IdCategoria",
                table: "TB_PRODUTO",
                newName: "IX_TB_PRODUTO_IdCategoria");

            migrationBuilder.RenameColumn(
                name: "IdCliente",
                table: "TB_PEDIDO",
                newName: "IdUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_PEDIDO_IdProduto",
                table: "TB_PEDIDO",
                newName: "IX_TB_PEDIDO_IdProduto");

            migrationBuilder.RenameIndex(
                name: "IX_PEDIDO_IdPagamento",
                table: "TB_PEDIDO",
                newName: "IX_TB_PEDIDO_IdPagamento");

            migrationBuilder.RenameIndex(
                name: "IX_PEDIDO_IdCliente",
                table: "TB_PEDIDO",
                newName: "IX_TB_PEDIDO_IdUsuario");

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "TB_USUARIO",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IdEndereco",
                table: "TB_USUARIO",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "TB_USUARIO",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_USUARIO",
                table: "TB_USUARIO",
                column: "IdUsuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_PRODUTO",
                table: "TB_PRODUTO",
                column: "IdProduto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_PEDIDO",
                table: "TB_PEDIDO",
                column: "IdPedido");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_PAGAMENTO",
                table: "TB_PAGAMENTO",
                column: "IdPagamento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_ENDERECO",
                table: "TB_ENDERECO",
                column: "IdEndereco");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_CATEGORIA",
                table: "TB_CATEGORIA",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_TB_USUARIO_IdEndereco",
                table: "TB_USUARIO",
                column: "IdEndereco");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PEDIDO_TB_PAGAMENTO_IdPagamento",
                table: "TB_PEDIDO",
                column: "IdPagamento",
                principalTable: "TB_PAGAMENTO",
                principalColumn: "IdPagamento",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PEDIDO_TB_PRODUTO_IdProduto",
                table: "TB_PEDIDO",
                column: "IdProduto",
                principalTable: "TB_PRODUTO",
                principalColumn: "IdProduto",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PEDIDO_TB_USUARIO_IdUsuario",
                table: "TB_PEDIDO",
                column: "IdUsuario",
                principalTable: "TB_USUARIO",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PRODUTO_TB_CATEGORIA_IdCategoria",
                table: "TB_PRODUTO",
                column: "IdCategoria",
                principalTable: "TB_CATEGORIA",
                principalColumn: "IdCategoria",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_USUARIO_TB_ENDERECO_IdEndereco",
                table: "TB_USUARIO",
                column: "IdEndereco",
                principalTable: "TB_ENDERECO",
                principalColumn: "IdEndereco",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
