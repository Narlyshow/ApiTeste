using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiTeste.Migrations
{
    /// <inheritdoc />
    public partial class CreateEnderecoColumnInContatosTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Contatos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Contatos");
        }
    }
}
