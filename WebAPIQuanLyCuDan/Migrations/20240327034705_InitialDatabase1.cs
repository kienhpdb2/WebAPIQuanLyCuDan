using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIQuanLyCuDan.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tenantApartment_apartment_ApartmentId",
                table: "tenantApartment");

            migrationBuilder.DropForeignKey(
                name: "FK_tenantApartment_tenant_TenantId",
                table: "tenantApartment");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "tenantApartment",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "tenantApartment",
                newName: "is_deleted");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "tenantApartment",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "ApartmentId",
                table: "tenantApartment",
                newName: "apartment_id");

            migrationBuilder.RenameColumn(
                name: "TenantId",
                table: "tenantApartment",
                newName: "tenant_id");

            migrationBuilder.RenameIndex(
                name: "IX_tenantApartment_ApartmentId",
                table: "tenantApartment",
                newName: "IX_tenantApartment_apartment_id");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "tenant",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "tenant",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "tenant",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "tenant",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "tenant",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "TenantId",
                table: "tenant",
                newName: "tenant_id");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "apartment",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "apartment",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "apartment",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "ApartmentId",
                table: "apartment",
                newName: "apartment_id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tenantApartment_apartment_apartment_id",
                table: "tenantApartment");

            migrationBuilder.DropForeignKey(
                name: "FK_tenantApartment_tenant_tenant_id",
                table: "tenantApartment");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "tenantApartment",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "is_deleted",
                table: "tenantApartment",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "tenantApartment",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "apartment_id",
                table: "tenantApartment",
                newName: "ApartmentId");

            migrationBuilder.RenameColumn(
                name: "tenant_id",
                table: "tenantApartment",
                newName: "TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_tenantApartment_apartment_id",
                table: "tenantApartment",
                newName: "IX_tenantApartment_ApartmentId");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "tenant",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "tenant",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "tenant",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "tenant",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "tenant",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "tenant_id",
                table: "tenant",
                newName: "TenantId");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "apartment",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "apartment",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "apartment",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "apartment_id",
                table: "apartment",
                newName: "ApartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_tenantApartment_apartment_ApartmentId",
                table: "tenantApartment",
                column: "ApartmentId",
                principalTable: "apartment",
                principalColumn: "ApartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tenantApartment_tenant_TenantId",
                table: "tenantApartment",
                column: "TenantId",
                principalTable: "tenant",
                principalColumn: "TenantId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
