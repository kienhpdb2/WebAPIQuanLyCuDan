using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIQuanLyCuDan.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tenantApartment_apartment_apartment_id",
                table: "tenantApartment");

            migrationBuilder.DropForeignKey(
                name: "FK_tenantApartment_tenant_tenant_id",
                table: "tenantApartment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tenantApartment",
                table: "tenantApartment");

            migrationBuilder.RenameTable(
                name: "tenantApartment",
                newName: "tenant_apartment");

            migrationBuilder.RenameIndex(
                name: "IX_tenantApartment_apartment_id",
                table: "tenant_apartment",
                newName: "IX_tenant_apartment_apartment_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tenant_apartment",
                table: "tenant_apartment",
                columns: new[] { "tenant_id", "apartment_id" });

            migrationBuilder.AddForeignKey(
                name: "FK_tenant_apartment_apartment_apartment_id",
                table: "tenant_apartment",
                column: "apartment_id",
                principalTable: "apartment",
                principalColumn: "apartment_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tenant_apartment_tenant_tenant_id",
                table: "tenant_apartment",
                column: "tenant_id",
                principalTable: "tenant",
                principalColumn: "tenant_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tenant_apartment_apartment_apartment_id",
                table: "tenant_apartment");

            migrationBuilder.DropForeignKey(
                name: "FK_tenant_apartment_tenant_tenant_id",
                table: "tenant_apartment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tenant_apartment",
                table: "tenant_apartment");

            migrationBuilder.RenameTable(
                name: "tenant_apartment",
                newName: "tenantApartment");

            migrationBuilder.RenameIndex(
                name: "IX_tenant_apartment_apartment_id",
                table: "tenantApartment",
                newName: "IX_tenantApartment_apartment_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tenantApartment",
                table: "tenantApartment",
                columns: new[] { "tenant_id", "apartment_id" });

            migrationBuilder.AddForeignKey(
                name: "FK_tenantApartment_apartment_apartment_id",
                table: "tenantApartment",
                column: "apartment_id",
                principalTable: "apartment",
                principalColumn: "apartment_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tenantApartment_tenant_tenant_id",
                table: "tenantApartment",
                column: "tenant_id",
                principalTable: "tenant",
                principalColumn: "tenant_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
