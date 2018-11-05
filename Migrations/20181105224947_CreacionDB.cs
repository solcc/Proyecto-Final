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
                name: "Cliente",
                columns: table => new
                {
                    idCliente = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Telefono = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.idCliente);
                });

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
                name: "Reservas",
                columns: table => new
                {
                    codReserva = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Hora = table.Column<DateTime>(nullable: false),
                    Monto = table.Column<float>(nullable: false),
                    idCliente = table.Column<int>(nullable: true),
                    MenuidMenu = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.codReserva);
                    table.ForeignKey(
                        name: "FK_Reservas_Menus_MenuidMenu",
                        column: x => x.MenuidMenu,
                        principalTable: "Menus",
                        principalColumn: "idMenu",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservas_Cliente_idCliente",
                        column: x => x.idCliente,
                        principalTable: "Cliente",
                        principalColumn: "idCliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "idCliente", "Apellido", "Nombre", "Telefono" },
                values: new object[] { 1, "Choque Chara", "Sol Milagros", 1256456778 });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "idCliente", "Apellido", "Nombre", "Telefono" },
                values: new object[] { 2, "Alayo Cuje", "Yaneli ", 456845543 });

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_MenuidMenu",
                table: "Reservas",
                column: "MenuidMenu");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_idCliente",
                table: "Reservas",
                column: "idCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
