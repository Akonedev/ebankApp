using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ebankApp.Data.Migrations
{
    public partial class addcustomdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Addr_City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Addr_Commune",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Addr_Country",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Addr_Departement",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Addr_Other_Precision",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Addr_PostalCode",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Addr_Province",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Addr_Region",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Addr_Street_Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Addr_Street_Number",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Addr_lat",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Addr_line1",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Addr_line2",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Addr_line3",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Addr_long",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NickName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Addr_City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Addr_Commune",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Addr_Country",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Addr_Departement",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Addr_Other_Precision",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Addr_PostalCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Addr_Province",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Addr_Region",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Addr_Street_Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Addr_Street_Number",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Addr_lat",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Addr_line1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Addr_line2",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Addr_line3",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Addr_long",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NickName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "AspNetUsers");
        }
    }
}
