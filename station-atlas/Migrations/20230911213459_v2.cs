using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace station_atlas.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdEndereco",
                table: "TB_USUARIO",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCategoria",
                table: "TB_PRODUTO",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPagamento",
                table: "TB_PEDIDO",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "TB_PEDIDO",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TB_ENDERECO",
                columns: table => new
                {
                    IdEndereco = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Logradouro = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Cep = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Complemento = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Cidade = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Estado = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ENDERECO", x => x.IdEndereco);
                });

            migrationBuilder.CreateTable(
                name: "TB_PAGAMENTO",
                columns: table => new
                {
                    IdPagamento = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DataPagamento = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Valor = table.Column<float>(type: "BINARY_FLOAT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PAGAMENTO", x => x.IdPagamento);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_USUARIO_IdEndereco",
                table: "TB_USUARIO",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PRODUTO_IdCategoria",
                table: "TB_PRODUTO",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PEDIDO_IdPagamento",
                table: "TB_PEDIDO",
                column: "IdPagamento");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PEDIDO_IdUsuario",
                table: "TB_PEDIDO",
                column: "IdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PEDIDO_TB_PAGAMENTO_IdPagamento",
                table: "TB_PEDIDO",
                column: "IdPagamento",
                principalTable: "TB_PAGAMENTO",
                principalColumn: "IdPagamento",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_PEDIDO_TB_PAGAMENTO_IdPagamento",
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

            migrationBuilder.DropTable(
                name: "TB_ENDERECO");

            migrationBuilder.DropTable(
                name: "TB_PAGAMENTO");

            migrationBuilder.DropIndex(
                name: "IX_TB_USUARIO_IdEndereco",
                table: "TB_USUARIO");

            migrationBuilder.DropIndex(
                name: "IX_TB_PRODUTO_IdCategoria",
                table: "TB_PRODUTO");

            migrationBuilder.DropIndex(
                name: "IX_TB_PEDIDO_IdPagamento",
                table: "TB_PEDIDO");

            migrationBuilder.DropIndex(
                name: "IX_TB_PEDIDO_IdUsuario",
                table: "TB_PEDIDO");

            migrationBuilder.DropColumn(
                name: "IdEndereco",
                table: "TB_USUARIO");

            migrationBuilder.DropColumn(
                name: "IdCategoria",
                table: "TB_PRODUTO");

            migrationBuilder.DropColumn(
                name: "IdPagamento",
                table: "TB_PEDIDO");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "TB_PEDIDO");
        }
    }
}
