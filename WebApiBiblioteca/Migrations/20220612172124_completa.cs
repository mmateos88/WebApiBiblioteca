using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiBiblioteca.Migrations
{
    public partial class completa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Editoriales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editoriales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Paginas = table.Column<int>(type: "int", precision: 1, scale: 5, nullable: false),
                    EditorialId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Libros_Editoriales_EditorialId",
                        column: x => x.EditorialId,
                        principalTable: "Editoriales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Editoriales",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "Susaeta" });

            migrationBuilder.InsertData(
                table: "Editoriales",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 2, "Anaya" });

            migrationBuilder.InsertData(
                table: "Editoriales",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 3, "Minotauro" });

            migrationBuilder.InsertData(
                table: "Libros",
                columns: new[] { "Id", "EditorialId", "Paginas", "Titulo" },
                values: new object[,]
                {
                    { 1, 1, 14, "Mi primer atlas" },
                    { 2, 1, 10, "Circula por la ciudad" },
                    { 3, 1, 32, "Mi mascota el dinosaurio" },
                    { 4, 2, 160, "Alma de elefante" },
                    { 5, 2, 120, "En un bosque de hoja caduca" },
                    { 6, 2, 112, "La primera tarde después de navidad" },
                    { 7, 2, 152, "El arca y yo" },
                    { 8, 2, 248, "Las chicas de la 305" },
                    { 9, 3, 504, "La naturaleza de la tierra media" },
                    { 10, 3, 344, "Sinopsis de cine" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Libros_EditorialId",
                table: "Libros",
                column: "EditorialId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Editoriales");
        }
    }
}
