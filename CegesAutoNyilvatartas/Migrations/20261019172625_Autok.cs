using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CegesAutoNyilvatartas.Migrations
{
    /// <inheritdoc />
    public partial class Autok : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modell = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rendszám = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Evjarat = table.Column<int>(type: "int", nullable: false),
                    PeopleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Auto_Peoples_PeopleId",
                        column: x => x.PeopleId,
                        principalTable: "Peoples",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auto_PeopleId",
                table: "Auto",
                column: "PeopleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auto");
        }
    }
}
