using Microsoft.EntityFrameworkCore.Migrations;

namespace citasm.Data.Migrations
{
    public partial class AddCitas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    citaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitapNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitapSeNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitapApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitapCorreo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitapAcomNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitaAcomApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitapDireccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitapDirecciondos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitapCuidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitapEstadop = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitapCodigop = table.Column<int>(type: "int", nullable: false),
                    CitapTelefonoArea = table.Column<int>(type: "int", nullable: false),
                    CitapNumero = table.Column<int>(type: "int", nullable: false),
                    CitapAreaW = table.Column<int>(type: "int", nullable: false),
                    CitapNumeroW = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.citaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citas");
        }
    }
}
