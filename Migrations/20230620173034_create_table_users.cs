using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApuestasWebCaballos.Migrations
{
    /// <inheritdoc />
    public partial class create_table_users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
             name: "usuario",
             columns: table => new
             {
                 Id = table.Column<int>(nullable: false)
                     .Annotation("SqlServer:Identity", "1, 1"),
                 Name = table.Column<string>(nullable: true),
                 Email = table.Column<string>(nullable: true),
                 EmailVerifiedAt = table.Column<DateTime>(nullable: true),
                 Password = table.Column<string>(nullable: true),
                 Dinero = table.Column<double>(nullable: true),
                 RoleId = table.Column<int>(nullable: false),
                 RememberToken = table.Column<string>(nullable: true),
                 CreatedAt = table.Column<DateTime>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                 UpdatedAt = table.Column<DateTime>(nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
             },
             constraints: table =>
             {
                 table.PrimaryKey("PK_usuario", x => x.Id);
                 table.ForeignKey(
                     name: "FK_Users_rol_RoleId",
                     column: x => x.RoleId,
                     principalTable: "rol",
                     principalColumn: "Id",
                     onDelete: ReferentialAction.Cascade);
             });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
               name: "usuario");
        }
    }
}
