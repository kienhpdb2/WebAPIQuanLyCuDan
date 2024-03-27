using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIQuanLyCuDan.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "created_at",
                table: "tenantApartment");

            migrationBuilder.DropColumn(
                name: "is_deleted",
                table: "tenantApartment");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "tenantApartment");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "tenant");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "tenant");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "apartment");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "apartment");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "tenantApartment",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "is_deleted",
                table: "tenantApartment",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "tenantApartment",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "tenant",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "tenant",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "apartment",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "apartment",
                type: "timestamp with time zone",
                nullable: true);
        }
    }
}
