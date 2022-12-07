using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backriae.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "boleta_Clasificadores",
                columns: table => new
                {
                    idboletaclasificador = table.Column<int>(name: "id_boleta_clasificador", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tiporegistro = table.Column<int>(name: "tipo_registro", type: "int", nullable: false),
                    codigo = table.Column<int>(type: "int", nullable: true),
                    codclasificador = table.Column<int>(name: "cod_clasificador", type: "int", nullable: false),
                    nombreclasificador = table.Column<string>(name: "nombre_clasificador", type: "nvarchar(max)", nullable: false),
                    importeunitarioclasificador = table.Column<float>(name: "importe_unitario_clasificador", type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_boleta_Clasificadores", x => x.idboletaclasificador);
                });

            migrationBuilder.CreateTable(
                name: "subtipo_Ingresos_FR",
                columns: table => new
                {
                    idsubtipo = table.Column<int>(name: "id_subtipo", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idtiporegistro = table.Column<int>(name: "id_tipo_registro", type: "int", nullable: false),
                    subtiporegistro = table.Column<int>(name: "subtipo_registro", type: "int", nullable: false),
                    nombresubtipo = table.Column<string>(name: "nombre_subtipo", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subtipo_Ingresos_FR", x => x.idsubtipo);
                });

            migrationBuilder.CreateTable(
                name: "subtipo_Ingresos_IP",
                columns: table => new
                {
                    idsubtipo = table.Column<int>(name: "id_subtipo", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idtiporegistro = table.Column<int>(name: "id_tipo_registro", type: "int", nullable: false),
                    subtiporegistro = table.Column<int>(name: "subtipo_registro", type: "int", nullable: false),
                    nombresubtipo = table.Column<string>(name: "nombre_subtipo", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subtipo_Ingresos_IP", x => x.idsubtipo);
                });

            migrationBuilder.CreateTable(
                name: "tipos_Registros",
                columns: table => new
                {
                    idtiporegistro = table.Column<int>(name: "id_tipo_registro", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tiporegistro = table.Column<int>(name: "tipo_registro", type: "int", nullable: false),
                    nombreregistro = table.Column<string>(name: "nombre_registro", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipos_Registros", x => x.idtiporegistro);
                });

            migrationBuilder.CreateTable(
                name: "registro_Frotatorios",
                columns: table => new
                {
                    idregistro = table.Column<int>(name: "id_registro", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idtiporegistro = table.Column<int>(name: "id_tipo_registro", type: "int", nullable: false),
                    nboleta = table.Column<int>(name: "n_boleta", type: "int", nullable: false),
                    nrecibo = table.Column<float>(name: "n_recibo", type: "real", nullable: false),
                    idsubtipo = table.Column<int>(name: "id_subtipo", type: "int", nullable: false),
                    importetotalboleta = table.Column<float>(name: "importe_total_boleta", type: "real", nullable: false),
                    igv = table.Column<float>(type: "real", nullable: false),
                    montoigv = table.Column<float>(name: "monto_igv", type: "real", nullable: false),
                    nombreempresa = table.Column<string>(name: "nombre_empresa", type: "nvarchar(max)", nullable: true),
                    notainformativa = table.Column<string>(name: "nota_informativa", type: "nvarchar(max)", nullable: true),
                    nombrefactura = table.Column<string>(name: "nombre_factura", type: "nvarchar(max)", nullable: true),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: true),
                    importedeposito = table.Column<float>(name: "importe_deposito", type: "real", nullable: true),
                    importetotaltipoip = table.Column<float>(name: "importe_total_tipo_ip", type: "real", nullable: true),
                    importetotaltipofr = table.Column<float>(name: "importe_total_tipo_fr", type: "real", nullable: true),
                    nvoucher = table.Column<int>(name: "n_voucher", type: "int", nullable: true),
                    montovoucher = table.Column<float>(name: "monto_voucher", type: "real", nullable: true),
                    ncheque = table.Column<int>(name: "n_cheque", type: "int", nullable: true),
                    montocheque = table.Column<float>(name: "monto_cheque", type: "real", nullable: true),
                    nombrebanco = table.Column<string>(name: "nombre_banco", type: "nvarchar(max)", nullable: true),
                    nnotaabono = table.Column<int>(name: "n_nota_abono", type: "int", nullable: true),
                    montonotaabono = table.Column<float>(name: "monto_nota_abono", type: "real", nullable: true),
                    textoglosa = table.Column<string>(name: "texto_glosa", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registro_Frotatorios", x => x.idregistro);
                    table.ForeignKey(
                        name: "FK_registro_Frotatorios_boleta_Clasificadores_n_boleta",
                        column: x => x.nboleta,
                        principalTable: "boleta_Clasificadores",
                        principalColumn: "id_boleta_clasificador",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "registro_Ipropios",
                columns: table => new
                {
                    idregistro = table.Column<int>(name: "id_registro", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idtiporegistro = table.Column<int>(name: "id_tipo_registro", type: "int", nullable: false),
                    nboleta = table.Column<int>(name: "n_boleta", type: "int", nullable: false),
                    nrecibo = table.Column<float>(name: "n_recibo", type: "real", nullable: false),
                    idsubtipo = table.Column<int>(name: "id_subtipo", type: "int", nullable: false),
                    importetotalboleta = table.Column<float>(name: "importe_total_boleta", type: "real", nullable: false),
                    ncheque = table.Column<int>(name: "n_cheque", type: "int", nullable: true),
                    montocheque = table.Column<float>(name: "monto_cheque", type: "real", nullable: true),
                    textoglosa = table.Column<string>(name: "texto_glosa", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registro_Ipropios", x => x.idregistro);
                    table.ForeignKey(
                        name: "FK_registro_Ipropios_boleta_Clasificadores_n_boleta",
                        column: x => x.nboleta,
                        principalTable: "boleta_Clasificadores",
                        principalColumn: "id_boleta_clasificador",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_registro_Frotatorios_n_boleta",
                table: "registro_Frotatorios",
                column: "n_boleta");

            migrationBuilder.CreateIndex(
                name: "IX_registro_Ipropios_n_boleta",
                table: "registro_Ipropios",
                column: "n_boleta");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "registro_Frotatorios");

            migrationBuilder.DropTable(
                name: "registro_Ipropios");

            migrationBuilder.DropTable(
                name: "subtipo_Ingresos_FR");

            migrationBuilder.DropTable(
                name: "subtipo_Ingresos_IP");

            migrationBuilder.DropTable(
                name: "tipos_Registros");

            migrationBuilder.DropTable(
                name: "boleta_Clasificadores");
        }
    }
}
