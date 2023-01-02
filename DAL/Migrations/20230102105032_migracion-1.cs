using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class migracion1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "sc_evaluacion");

            migrationBuilder.CreateTable(
                name: "eva_cat_evaluacion",
                schema: "sc_evaluacion",
                columns: table => new
                {
                    Codevaluacion = table.Column<string>(name: "Cod_evaluacion", type: "text", nullable: false),
                    Descevaluacion = table.Column<string>(name: "Desc_evaluacion", type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eva_cat_evaluacion", x => x.Codevaluacion);
                });

            migrationBuilder.CreateTable(
                name: "eva_tch_notas_evaluacion",
                schema: "sc_evaluacion",
                columns: table => new
                {
                    Idnotaevaluacion = table.Column<int>(name: "Id_nota_evaluacion", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Mduuid = table.Column<string>(name: "Md_uuid", type: "text", nullable: false),
                    Mdfch = table.Column<DateTime>(name: "Md_fch", type: "timestamp without time zone", nullable: false),
                    Codalumno = table.Column<string>(name: "Cod_alumno", type: "text", nullable: false),
                    Notaevaluacion = table.Column<int>(name: "Nota_evaluacion", type: "integer", nullable: false),
                    Codevaluacion = table.Column<string>(name: "Cod_evaluacion", type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eva_tch_notas_evaluacion", x => x.Idnotaevaluacion);
                    table.ForeignKey(
                        name: "FK_eva_tch_notas_evaluacion_eva_cat_evaluacion_Cod_evaluacion",
                        column: x => x.Codevaluacion,
                        principalSchema: "sc_evaluacion",
                        principalTable: "eva_cat_evaluacion",
                        principalColumn: "Cod_evaluacion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_eva_tch_notas_evaluacion_Cod_evaluacion",
                schema: "sc_evaluacion",
                table: "eva_tch_notas_evaluacion",
                column: "Cod_evaluacion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "eva_tch_notas_evaluacion",
                schema: "sc_evaluacion");

            migrationBuilder.DropTable(
                name: "eva_cat_evaluacion",
                schema: "sc_evaluacion");
        }
    }
}
