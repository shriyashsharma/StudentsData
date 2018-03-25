using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StudentsData.Migrations
{
    public partial class FatherList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_FatherDetail_FatherId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_FatherId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FatherId",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "StudentsId",
                table: "FatherDetail",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FatherDetail_StudentsId",
                table: "FatherDetail",
                column: "StudentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_FatherDetail_Students_StudentsId",
                table: "FatherDetail",
                column: "StudentsId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FatherDetail_Students_StudentsId",
                table: "FatherDetail");

            migrationBuilder.DropIndex(
                name: "IX_FatherDetail_StudentsId",
                table: "FatherDetail");

            migrationBuilder.DropColumn(
                name: "StudentsId",
                table: "FatherDetail");

            migrationBuilder.AddColumn<int>(
                name: "FatherId",
                table: "Students",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_FatherId",
                table: "Students",
                column: "FatherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_FatherDetail_FatherId",
                table: "Students",
                column: "FatherId",
                principalTable: "FatherDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
