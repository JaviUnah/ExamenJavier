using Microsoft.EntityFrameworkCore.Migrations;

namespace EXAMEN.Data.Migrations
{
    public partial class AddTablaIdentificacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Identifs",
                columns: table => new
                {
                    IdentificacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentificacionCodigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentificacionApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentificacionNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentificacionApodo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentificacionDireccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentificacionCPostal = table.Column<int>(type: "int", nullable: false),
                    IdentificacionTelefono = table.Column<int>(type: "int", nullable: false),
                    IdentificacionCelular = table.Column<int>(type: "int", nullable: false),
                    IdentificacionFax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentificacionEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentificacionObservacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identifs", x => x.IdentificacionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Identifs");
        }
    }
}
