using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AstroPod.Migrations
{
    public partial class List : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Content_AspNetUsers_UserId",
                table: "Content");

            migrationBuilder.DropIndex(
                name: "IX_Content_UserId",
                table: "Content");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Content");

            migrationBuilder.AddColumn<string>(
                name: "ContentId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ContentId",
                table: "AspNetUsers",
                column: "ContentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Content_ContentId",
                table: "AspNetUsers",
                column: "ContentId",
                principalTable: "Content",
                principalColumn: "ContentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Content_ContentId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ContentId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ContentId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Content",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Content_UserId",
                table: "Content",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Content_AspNetUsers_UserId",
                table: "Content",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
