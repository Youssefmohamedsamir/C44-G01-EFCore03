using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crew_AirCraft_AirCraftId",
                table: "Crew");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Airline_AirlineId",
                table: "Transaction");

            migrationBuilder.AddForeignKey(
                name: "FK_Crew_AirCraft_AirCraftId",
                table: "Crew",
                column: "AirCraftId",
                principalTable: "AirCraft",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Airline_AirlineId",
                table: "Transaction",
                column: "AirlineId",
                principalTable: "Airline",
                principalColumn: "AirlineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crew_AirCraft_AirCraftId",
                table: "Crew");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Airline_AirlineId",
                table: "Transaction");

            migrationBuilder.AddForeignKey(
                name: "FK_Crew_AirCraft_AirCraftId",
                table: "Crew",
                column: "AirCraftId",
                principalTable: "AirCraft",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Airline_AirlineId",
                table: "Transaction",
                column: "AirlineId",
                principalTable: "Airline",
                principalColumn: "AirlineId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
