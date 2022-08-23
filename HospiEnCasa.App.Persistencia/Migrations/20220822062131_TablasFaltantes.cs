using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospiEnCasa.App.Persistencia.Migrations
{
    public partial class TablasFaltantes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ciudad",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnfermeraId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Especialidad",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FamiliarId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNacimento",
                table: "Personas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HistoriaId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HorasLaborales",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Longitude",
                table: "Personas",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MedicoId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Parentesco",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegistroRethus",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TarjetaProfesional",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "latitude",
                table: "Personas",
                type: "real",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Historias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Entorno = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SignosVitales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valor = table.Column<float>(type: "real", nullable: false),
                    Signo = table.Column<int>(type: "int", nullable: false),
                    pacienteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignosVitales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SignosVitales_Personas_pacienteId",
                        column: x => x.pacienteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SugerenciasCuidado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    historiaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SugerenciasCuidado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SugerenciasCuidado_Historias_historiaId",
                        column: x => x.historiaId,
                        principalTable: "Historias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_EnfermeraId",
                table: "Personas",
                column: "EnfermeraId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_FamiliarId",
                table: "Personas",
                column: "FamiliarId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_HistoriaId",
                table: "Personas",
                column: "HistoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_MedicoId",
                table: "Personas",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_SignosVitales_pacienteId",
                table: "SignosVitales",
                column: "pacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_SugerenciasCuidado_historiaId",
                table: "SugerenciasCuidado",
                column: "historiaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Historias_HistoriaId",
                table: "Personas",
                column: "HistoriaId",
                principalTable: "Historias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Personas_EnfermeraId",
                table: "Personas",
                column: "EnfermeraId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Personas_FamiliarId",
                table: "Personas",
                column: "FamiliarId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Personas_MedicoId",
                table: "Personas",
                column: "MedicoId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Historias_HistoriaId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Personas_EnfermeraId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Personas_FamiliarId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Personas_MedicoId",
                table: "Personas");

            migrationBuilder.DropTable(
                name: "SignosVitales");

            migrationBuilder.DropTable(
                name: "SugerenciasCuidado");

            migrationBuilder.DropTable(
                name: "Historias");

            migrationBuilder.DropIndex(
                name: "IX_Personas_EnfermeraId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_FamiliarId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_HistoriaId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_MedicoId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Ciudad",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "EnfermeraId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Especialidad",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "FamiliarId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "FechaNacimento",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "HistoriaId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "HorasLaborales",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "MedicoId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Parentesco",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "RegistroRethus",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "TarjetaProfesional",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "latitude",
                table: "Personas");
        }
    }
}
