using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.Migrations
{
    public partial class proyectofinalcontactos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "numPersonas",
                table: "Reservas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Contactos",
                columns: table => new
                {
                    idContacto = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    Correo = table.Column<string>(nullable: false),
                    Asunto = table.Column<string>(nullable: false),
                    Mensaje = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactos", x => x.idContacto);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contactos");

            migrationBuilder.DropColumn(
                name: "numPersonas",
                table: "Reservas");
        }
    }
}
