using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StudentsData.Migrations
{
    public partial class StudentInStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FatherDetail_Students_StudentsId",
                table: "FatherDetail");

            migrationBuilder.RenameColumn(
                name: "StudentsId",
                table: "FatherDetail",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_FatherDetail_StudentsId",
                table: "FatherDetail",
                newName: "IX_FatherDetail_StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_FatherDetail_Students_StudentId",
                table: "FatherDetail",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FatherDetail_Students_StudentId",
                table: "FatherDetail");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "FatherDetail",
                newName: "StudentsId");

            migrationBuilder.RenameIndex(
                name: "IX_FatherDetail_StudentId",
                table: "FatherDetail",
                newName: "IX_FatherDetail_StudentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_FatherDetail_Students_StudentsId",
                table: "FatherDetail",
                column: "StudentsId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
