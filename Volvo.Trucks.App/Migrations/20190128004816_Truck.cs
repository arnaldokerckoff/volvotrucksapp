using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Volvo.Trucks.App.Migrations
{
    public partial class Truck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Versao",
                table: "Truck",
                newName: "Version");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Truck",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Ano",
                table: "Truck",
                newName: "Year");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Truck",
                newName: "Ano");

            migrationBuilder.RenameColumn(
                name: "Version",
                table: "Truck",
                newName: "Versao");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Truck",
                newName: "Nome");
        }
    }
}
