using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Airline",
                columns: new[] { "AirlineId", "Address", "Contact_Person", "Name", "Phones" },
                values: new object[,]
                {
                    { 10, null, null, "EgyptAir", 1124594540 },
                    { 20, null, null, "EgyptAir", 1124594540 },
                    { 30, null, null, "EgyptAir", 1124594540 },
                    { 40, null, null, "EgyptAir", 1124594540 }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Address", "AirEmpId", "AirlineId", "Day", "Gender", "Name", "Position", "Qualifications" },
                values: new object[,]
                {
                    { 1, null, 10, null, null, "\0", "Youssef Mohamed", "Pilot", null },
                    { 2, null, 20, null, null, "\0", "Ahme Bihbity", "breaker", null },
                    { 3, null, 30, null, null, "\0", "Torky", "Programmer", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Airline",
                keyColumn: "AirlineId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Airline",
                keyColumn: "AirlineId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Airline",
                keyColumn: "AirlineId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Airline",
                keyColumn: "AirlineId",
                keyValue: 30);

            migrationBuilder.AlterColumn<int>(
                name: "Position",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
