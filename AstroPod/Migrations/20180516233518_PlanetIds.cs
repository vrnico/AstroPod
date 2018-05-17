using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AstroPod.Migrations
{
    public partial class PlanetIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JupiterId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MarsId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MercId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NeptuneId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SaturnId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UranusId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VenusId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JupiterId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MarsId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MercId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NeptuneId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SaturnId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UranusId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "VenusId",
                table: "AspNetUsers");
        }
    }
}
