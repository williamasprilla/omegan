﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Omegan.Infrastructure.Persistence;

#nullable disable

namespace Omegan.Infrastructure.Migrations
{
    [DbContext(typeof(OmeganDbContext))]
    [Migration("20230110234038_addFieldsEjecucion")]
    partial class addFieldsEjecucion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "b947fb18-600f-4057-b05e-d306abffedb6",
                            ConcurrencyStamp = "e88a96dc-dd44-4cb0-802d-83e3d33b6b41",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "aebfc368-0c43-4b94-8cce-26c277ec2e33",
                            ConcurrencyStamp = "06b7c246-3520-4da7-ab28-4de97e2fbd92",
                            Name = "Empresa Exportadora",
                            NormalizedName = "EMPRESA EXPORTADORA"
                        },
                        new
                        {
                            Id = "93296f46-5fd1-4b67-bb8d-9a9008adc8e6",
                            ConcurrencyStamp = "a4dbedd9-a72c-4cab-bafc-02cafe5e5ec5",
                            Name = "Representante Lejal",
                            NormalizedName = "Representante Lejal"
                        },
                        new
                        {
                            Id = "a0b13f5f-1fdc-4937-99ac-91c4a5c8e1bc",
                            ConcurrencyStamp = "4fa6906f-86f4-4dbd-8f3c-d699c4e36d39",
                            Name = "Comite Directivo",
                            NormalizedName = "COMITE DIRECTIVO"
                        },
                        new
                        {
                            Id = "b344f3b4-1df4-449e-8553-9dd7640820a2",
                            ConcurrencyStamp = "93955196-a96c-460d-be18-c0b91f62fb53",
                            Name = "Secretaria Tecnica",
                            NormalizedName = "SECRETARIA TECNICA"
                        },
                        new
                        {
                            Id = "10096115-e173-4e82-903f-8b4c8f8e2ceb",
                            ConcurrencyStamp = "0dd40951-1705-4a53-a1eb-e3342a0b91a6",
                            Name = "Coordinacion Operactiva",
                            NormalizedName = "COORDINACION OPERACTIVA"
                        },
                        new
                        {
                            Id = "9cd3b078-3254-4c05-b404-e527ec616c89",
                            ConcurrencyStamp = "fd8d2381-3bce-4fdb-a02f-8892acc904ac",
                            Name = "Profesional I",
                            NormalizedName = "PROFESIONAL I"
                        },
                        new
                        {
                            Id = "3a52dfb8-8595-487e-bd07-2e876c8291a5",
                            ConcurrencyStamp = "0b12d613-dad5-4f7b-9d2a-bf2d8282de6a",
                            Name = "Auditoria Interna",
                            NormalizedName = "AUDITORIA INTERNA"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "7fa985ac-095c-469b-b98d-8e09a947d66a",
                            RoleId = "b947fb18-600f-4057-b05e-d306abffedb6"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Omegan.Domain.Announcement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DestinationCountry")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Ejecucion")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("IdDestinationCountry")
                        .HasColumnType("int");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PortShipment")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ShippingDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Announcement");
                });

            modelBuilder.Entity("Omegan.Domain.Archive", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Base64")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("State")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Archives");
                });

            modelBuilder.Entity("Omegan.Domain.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NIT")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("NameCompany")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Omegan.Domain.Compensation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("AnnouncementDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("AnnouncementNumber")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DestinationCountry")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Ejecucion")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("ExporterDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdDestinationCountry")
                        .HasColumnType("int");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Compensation");
                });

            modelBuilder.Entity("Omegan.Domain.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("CurrentValue")
                        .HasColumnType("double");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<string>("nameCountry")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Countrys");
                });

            modelBuilder.Entity("Omegan.Domain.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "7fa985ac-095c-469b-b98d-8e09a947d66a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0358fc80-2f86-4c49-9488-96a4810ea7c4",
                            Email = "admin@locahost.com",
                            EmailConfirmed = true,
                            FullName = "Omegan Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@locahost.com",
                            NormalizedUserName = "omeganadmin",
                            PasswordHash = "AQAAAAEAACcQAAAAEENgdfIeXoA7fJByZEla2gLsG2UHzhAfgHqMNiWczqkPFhpk7NTbpvLK6FzA0nNk2g==",
                            PhoneNumber = "3175226569",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "05f94e83-5fcd-4e43-ae86-24e475b022db",
                            TwoFactorEnabled = false,
                            UserName = "OmeganAdmin"
                        });
                });

            modelBuilder.Entity("Omegan.Domain.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("TariffItem")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Carne en canal",
                            LastModifiedBy = "",
                            LastModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TariffItem = "001"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Carne industrial",
                            LastModifiedBy = "",
                            LastModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TariffItem = "002"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Carne empacada al vacio extra",
                            LastModifiedBy = "",
                            LastModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TariffItem = "003"
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = "",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Carne empacada al vacio primera",
                            LastModifiedBy = "",
                            LastModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TariffItem = "004"
                        },
                        new
                        {
                            Id = 5,
                            CreatedBy = "",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Carne empacada al vacio segunda",
                            LastModifiedBy = "",
                            LastModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TariffItem = "005"
                        },
                        new
                        {
                            Id = 6,
                            CreatedBy = "",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Leche en polvo",
                            LastModifiedBy = "",
                            LastModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TariffItem = "006"
                        },
                        new
                        {
                            Id = 7,
                            CreatedBy = "",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Leche UHT",
                            LastModifiedBy = "",
                            LastModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TariffItem = "007"
                        },
                        new
                        {
                            Id = 8,
                            CreatedBy = "",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Quesos maduros",
                            LastModifiedBy = "",
                            LastModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TariffItem = "008"
                        });
                });

            modelBuilder.Entity("Omegan.Domain.ProductAnnouncement", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("AnnouncementId")
                        .HasColumnType("int");

                    b.Property<decimal>("Kilogram")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("ProductId", "AnnouncementId");

                    b.HasIndex("AnnouncementId");

                    b.ToTable("ProductAnnouncements");
                });

            modelBuilder.Entity("Omegan.Domain.ProductCompensation", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("CompensationId")
                        .HasColumnType("int");

                    b.Property<double>("KilogramsExported")
                        .HasColumnType("double");

                    b.Property<double>("OffsetKilogram")
                        .HasColumnType("double");

                    b.Property<double>("Subtotal")
                        .HasColumnType("double");

                    b.HasKey("ProductId", "CompensationId");

                    b.HasIndex("CompensationId");

                    b.ToTable("ProductCompensation");
                });

            modelBuilder.Entity("Omegan.Domain.Trm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("InitialDivision")
                        .HasColumnType("double");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("MonthlyBudget")
                        .HasColumnType("double");

                    b.Property<int>("NumberCompanies")
                        .HasColumnType("int");

                    b.Property<double>("TRMValue")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Trm");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Omegan.Domain.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Omegan.Domain.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Omegan.Domain.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Omegan.Domain.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Omegan.Domain.Announcement", b =>
                {
                    b.HasOne("Omegan.Domain.Company", "Company")
                        .WithMany("Announcements")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Omegan.Domain.Archive", b =>
                {
                    b.HasOne("Omegan.Domain.Company", "Company")
                        .WithMany("Archives")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Omegan.Domain.Company", b =>
                {
                    b.HasOne("Omegan.Domain.Models.ApplicationUser", "User")
                        .WithOne("Company")
                        .HasForeignKey("Omegan.Domain.Company", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Omegan.Domain.Compensation", b =>
                {
                    b.HasOne("Omegan.Domain.Company", "Company")
                        .WithMany("Compensation")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Omegan.Domain.ProductAnnouncement", b =>
                {
                    b.HasOne("Omegan.Domain.Announcement", "Announcement")
                        .WithMany("ProductAnnouncements")
                        .HasForeignKey("AnnouncementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Omegan.Domain.Product", "Product")
                        .WithMany("ProductAnnouncements")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Announcement");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Omegan.Domain.ProductCompensation", b =>
                {
                    b.HasOne("Omegan.Domain.Compensation", "Compensation")
                        .WithMany("ProductCompensation")
                        .HasForeignKey("CompensationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Omegan.Domain.Product", "Product")
                        .WithMany("ProductCompensation")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Compensation");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Omegan.Domain.Announcement", b =>
                {
                    b.Navigation("ProductAnnouncements");
                });

            modelBuilder.Entity("Omegan.Domain.Company", b =>
                {
                    b.Navigation("Announcements");

                    b.Navigation("Archives");

                    b.Navigation("Compensation");
                });

            modelBuilder.Entity("Omegan.Domain.Compensation", b =>
                {
                    b.Navigation("ProductCompensation");
                });

            modelBuilder.Entity("Omegan.Domain.Models.ApplicationUser", b =>
                {
                    b.Navigation("Company");
                });

            modelBuilder.Entity("Omegan.Domain.Product", b =>
                {
                    b.Navigation("ProductAnnouncements");

                    b.Navigation("ProductCompensation");
                });
#pragma warning restore 612, 618
        }
    }
}
