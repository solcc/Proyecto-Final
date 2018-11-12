using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.Migrations
{
    public partial class proyectofinal_reservas_nombre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Reservas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Reservas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Reservas");
        }
    }
}
