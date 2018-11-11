using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.Migrations
{
    public partial class CreacionDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    idMenu = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Precio = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.idMenu);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    idUsuario = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: true),
                    Telefono = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.idUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    codReserva = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Hora = table.Column<DateTime>(nullable: false),
                    Monto = table.Column<float>(nullable: false),
                    idUsuario = table.Column<int>(nullable: true),
                    idMenu = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.codReserva);
                    table.ForeignKey(
                        name: "FK_Reservas_Menus_idMenu",
                        column: x => x.idMenu,
                        principalTable: "Menus",
                        principalColumn: "idMenu",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservas_Usuario_idUsuario",
                        column: x => x.idUsuario,
                        principalTable: "Usuario",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "idUsuario", "Apellido", "Correo", "Nombre", "Password", "Telefono" },
                values: new object[] { 1, "Choque Chara", "sol.choque@usil.pe", "Sol Milagros", "12345", 1256456778 });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "idUsuario", "Apellido", "Correo", "Nombre", "Password", "Telefono" },
                values: new object[] { 2, "Alayo Cuje", "yaneli.alayo@usil.pe", "Yaneli ", "678910", 456845543 });

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_idMenu",
                table: "Reservas",
                column: "idMenu");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_idUsuario",
                table: "Reservas",
                column: "idUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
