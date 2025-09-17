using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class Transaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AirCraft_Airlines_AilineId",
                table: "AirCraft");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Airlines_AirEmpId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Airlines_AirlineId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Airlines",
                table: "Airlines");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameTable(
                name: "Airlines",
                newName: "Airline");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_AirlineId",
                table: "Employee",
                newName: "IX_Employee_AirlineId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_AirEmpId",
                table: "Employee",
                newName: "IX_Employee_AirEmpId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Airline",
                table: "Airline",
                column: "AirlineId");

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirlineId = table.Column<int>(type: "int", nullable: false),
                    AirlineId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transaction_Airline_AirlineId",
                        column: x => x.AirlineId,
                        principalTable: "Airline",
                        principalColumn: "AirlineId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transaction_Airline_AirlineId1",
                        column: x => x.AirlineId1,
                        principalTable: "Airline",
                        principalColumn: "AirlineId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_AirlineId",
                table: "Transaction",
                column: "AirlineId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_AirlineId1",
                table: "Transaction",
                column: "AirlineId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AirCraft_Airline_AilineId",
                table: "AirCraft",
                column: "AilineId",
                principalTable: "Airline",
                principalColumn: "AirlineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Airline_AirEmpId",
                table: "Employee",
                column: "AirEmpId",
                principalTable: "Airline",
                principalColumn: "AirlineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Airline_AirlineId",
                table: "Employee",
                column: "AirlineId",
                principalTable: "Airline",
                principalColumn: "AirlineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AirCraft_Airline_AilineId",
                table: "AirCraft");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Airline_AirEmpId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Airline_AirlineId",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Airline",
                table: "Airline");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "Airline",
                newName: "Airlines");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_AirlineId",
                table: "Employees",
                newName: "IX_Employees_AirlineId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_AirEmpId",
                table: "Employees",
                newName: "IX_Employees_AirEmpId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Airlines",
                table: "Airlines",
                column: "AirlineId");

            migrationBuilder.AddForeignKey(
                name: "FK_AirCraft_Airlines_AilineId",
                table: "AirCraft",
                column: "AilineId",
                principalTable: "Airlines",
                principalColumn: "AirlineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Airlines_AirEmpId",
                table: "Employees",
                column: "AirEmpId",
                principalTable: "Airlines",
                principalColumn: "AirlineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Airlines_AirlineId",
                table: "Employees",
                column: "AirlineId",
                principalTable: "Airlines",
                principalColumn: "AirlineId");
        }
    }
}
