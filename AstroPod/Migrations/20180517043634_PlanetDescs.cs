using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AstroPod.Migrations
{
    public partial class PlanetDescs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JupiterDesc",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MarsDesc",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MercDesc",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MoonDesc",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NeptuneDesc",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaturnDesc",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UranusDesc",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VenusDesc",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JupiterDesc",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MarsDesc",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MercDesc",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MoonDesc",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NeptuneDesc",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SaturnDesc",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UranusDesc",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "VenusDesc",
                table: "AspNetUsers");
        }
    }
}
