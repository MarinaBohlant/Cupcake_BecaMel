using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Projeto3DS.Migrations
{
    /// <inheritdoc />
    public partial class cup_n_cakes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    categoria_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    categoria_nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    desc = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.categoria_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cupcake",
                columns: table => new
                {
                    cupcake_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    desc_curta = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    desc_detalhe = table.Column<string>(type: "longtext", nullable: false),
                    em_estoque = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    nome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    preco = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    img_url = table.Column<string>(type: "longtext", nullable: false),
                    cupcake_preferido = table.Column<string>(type: "longtext", nullable: false),
                    img_miniatura = table.Column<string>(type: "longtext", nullable: false),
                    categoria_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cupcake", x => x.cupcake_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Cupcake");
        }
    }
}
