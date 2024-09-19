using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class sqlitelocal_migration_450 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meccsek",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    fordulo = table.Column<int>(type: "INTEGER", nullable: false),
                    haziveg = table.Column<int>(type: "INTEGER", nullable: false),
                    vendegveg = table.Column<int>(type: "INTEGER", nullable: false),
                    hazaifelido = table.Column<int>(type: "INTEGER", nullable: false),
                    vendegfelido = table.Column<int>(type: "INTEGER", nullable: false),
                    hazainev = table.Column<string>(type: "TEXT", nullable: true),
                    vendegnev = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meccsek", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meccsek");
        }
    }
}
