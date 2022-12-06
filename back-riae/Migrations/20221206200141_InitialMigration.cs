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
                name: "subtipo_Ingresos",
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
                    table.PrimaryKey("PK_subtipo_Ingresos", x => x.idsubtipo);
                    table.ForeignKey(
                        name: "FK_subtipo_Ingresos_tipos_Registros_id_tipo_registro",
                        column: x => x.idtiporegistro,
                        principalTable: "tipos_Registros",
                        principalColumn: "id_tipo_registro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_subtipo_Ingresos_id_tipo_registro",
                table: "subtipo_Ingresos",
                column: "id_tipo_registro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "subtipo_Ingresos");

            migrationBuilder.DropTable(
                name: "tipos_Registros");
        }
    }
}
