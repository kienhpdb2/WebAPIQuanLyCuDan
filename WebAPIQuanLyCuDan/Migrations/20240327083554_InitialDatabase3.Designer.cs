﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebAPIQuanLyCuDan.Entity;

#nullable disable

namespace WebAPIQuanLyCuDan.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240327083554_InitialDatabase3")]
    partial class InitialDatabase3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebAPIQuanLyCuDan.Models.Apartment", b =>
                {
                    b.Property<int>("apartment_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("apartment_id"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("apartment_id");

                    b.ToTable("apartment");
                });

            modelBuilder.Entity("WebAPIQuanLyCuDan.Models.Tenant", b =>
                {
                    b.Property<int>("tenant_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("tenant_id"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("tenant_id");

                    b.ToTable("tenant");
                });

            modelBuilder.Entity("WebAPIQuanLyCuDan.Models.TenantApartment", b =>
                {
                    b.Property<int>("tenant_id")
                        .HasColumnType("integer");

                    b.Property<int>("apartment_id")
                        .HasColumnType("integer");

                    b.HasKey("tenant_id", "apartment_id");

                    b.HasIndex("apartment_id");

                    b.ToTable("tenant_apartment");
                });

            modelBuilder.Entity("WebAPIQuanLyCuDan.Models.TenantApartment", b =>
                {
                    b.HasOne("WebAPIQuanLyCuDan.Models.Apartment", "apartment")
                        .WithMany("tenant_apartments")
                        .HasForeignKey("apartment_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPIQuanLyCuDan.Models.Tenant", "tenant")
                        .WithMany("tenant_apartments")
                        .HasForeignKey("tenant_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("apartment");

                    b.Navigation("tenant");
                });

            modelBuilder.Entity("WebAPIQuanLyCuDan.Models.Apartment", b =>
                {
                    b.Navigation("tenant_apartments");
                });

            modelBuilder.Entity("WebAPIQuanLyCuDan.Models.Tenant", b =>
                {
                    b.Navigation("tenant_apartments");
                });
#pragma warning restore 612, 618
        }
    }
}
