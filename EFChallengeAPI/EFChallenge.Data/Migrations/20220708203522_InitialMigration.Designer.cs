﻿// <auto-generated />
using System;
using EFChallenge.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFChallenge.Data.Migrations
{
    [DbContext(typeof(EFChallengeDbContext))]
    [Migration("20220708203522_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFChallenge.Data.Models.Company.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AddressTypeId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("CountyId")
                        .HasColumnType("int");

                    b.Property<string>("Line1")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Line2")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("ZipPostalCode")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("CountyId");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressTypeId = 2,
                            City = "Portland",
                            CountyId = 1,
                            Line1 = "4800 Meadows Road, Suite 300 Lake Oswego",
                            ZipPostalCode = "97035"
                        },
                        new
                        {
                            Id = 2,
                            AddressTypeId = 1,
                            City = "Guadalajara",
                            CountyId = 2,
                            Line1 = "Av. de las Américas 1536, Country Club",
                            ZipPostalCode = "44637"
                        });
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Company.AddressType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("AddressTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Physical Address"
                        },
                        new
                        {
                            Id = 2,
                            Name = "IRS Address"
                        });
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Company.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Unosquare"
                        });
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Company.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "United States of America"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mexico"
                        });
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Company.County", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("Counties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Washington",
                            StateId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Guadalajara",
                            StateId = 2
                        });
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Company.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("States");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "Oregon"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 2,
                            Name = "Jalisco"
                        });
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.Identifier", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Identifiers");
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.IdentifierType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("IdentifierTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Barcode"
                        },
                        new
                        {
                            Id = 2,
                            Name = "QR Code"
                        },
                        new
                        {
                            Id = 3,
                            Name = "RFID Chip"
                        });
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ItemStatusId")
                        .HasColumnType("int");

                    b.Property<int>("ItemSubTypeId")
                        .HasColumnType("int");

                    b.Property<int>("ItemTypeId")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<Guid?>("ParentItemId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ItemStatusId");

                    b.HasIndex("ItemSubTypeId");

                    b.HasIndex("ItemTypeId");

                    b.HasIndex("ParentItemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.ItemAddendum", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("KeyField")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("ItemAddenda");
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.ItemContainerConstraint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ItemTypeId")
                        .HasColumnType("int");

                    b.Property<long>("Max")
                        .HasColumnType("bigint");

                    b.Property<long>("Min")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("ItemContainerConstraints");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ItemTypeId = 1,
                            Max = 1L,
                            Min = 1L
                        },
                        new
                        {
                            Id = 2,
                            ItemTypeId = 2,
                            Max = 24L,
                            Min = 1L
                        },
                        new
                        {
                            Id = 3,
                            ItemTypeId = 3,
                            Max = 4L,
                            Min = 1L
                        });
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.ItemIdentifier", b =>
                {
                    b.Property<Guid>("ItemIdentifierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ItemIdentifierId");

                    b.ToTable("ItemIdentifiers");
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.ItemStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("ItemStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "In Warehouse"
                        },
                        new
                        {
                            Id = 2,
                            Name = "In Transit"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Delivered"
                        });
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.ItemSubType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("ItemSubTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Can"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Plastic"
                        });
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.ItemType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("ItemTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Coke"
                        },
                        new
                        {
                            Id = 2,
                            Name = "24 Cokes Package"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Box with 4 Cokes Package"
                        });
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Company.Address", b =>
                {
                    b.HasOne("EFChallenge.Data.Models.Company.County", "County")
                        .WithMany()
                        .HasForeignKey("CountyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("County");
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Company.County", b =>
                {
                    b.HasOne("EFChallenge.Data.Models.Company.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Company.State", b =>
                {
                    b.HasOne("EFChallenge.Data.Models.Company.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.Item", b =>
                {
                    b.HasOne("EFChallenge.Data.Models.Item.ItemStatus", "ItemStatus")
                        .WithMany()
                        .HasForeignKey("ItemStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFChallenge.Data.Models.Item.ItemSubType", "ItemSubType")
                        .WithMany()
                        .HasForeignKey("ItemSubTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFChallenge.Data.Models.Item.ItemType", "ItemType")
                        .WithMany()
                        .HasForeignKey("ItemTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFChallenge.Data.Models.Item.Item", "ParentItem")
                        .WithMany()
                        .HasForeignKey("ParentItemId");

                    b.Navigation("ItemStatus");

                    b.Navigation("ItemSubType");

                    b.Navigation("ItemType");

                    b.Navigation("ParentItem");
                });
#pragma warning restore 612, 618
        }
    }
}
