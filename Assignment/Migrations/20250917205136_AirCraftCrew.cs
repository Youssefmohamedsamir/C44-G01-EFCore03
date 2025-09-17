using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class AirCraftCrew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Crew",
                columns: table => new
                {
                    Maj_Pilot = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AirCraftId = table.Column<int>(type: "int", nullable: false),
                    Assis_Pilot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Host1 = table.Column<int>(type: "int", nullable: false),
                    Host2 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crew", x => new { x.AirCraftId, x.Maj_Pilot });
                    table.ForeignKey(
                        name: "FK_Crew_AirCraft_AirCraftId",
                        column: x => x.AirCraftId,
                        principalTable: "AirCraft",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Crew_AirCraftId",
                table: "Crew",
                column: "AirCraftId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Crew");
        }
    }
}
