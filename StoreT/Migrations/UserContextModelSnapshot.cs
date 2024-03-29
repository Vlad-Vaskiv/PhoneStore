﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreT.Models;

namespace StoreT.Migrations
{
    [DbContext(typeof(UserContext))]
    partial class UserContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StoreT.Models.Charachteristic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ModelId");

                    b.Property<string>("battery");

                    b.Property<string>("camera");

                    b.Property<string>("display");

                    b.Property<string>("others");

                    b.Property<string>("price");

                    b.Property<string>("processor");

                    b.Property<string>("storage");

                    b.HasKey("Id");

                    b.HasIndex("ModelId")
                        .IsUnique();

                    b.ToTable("Charachteristics");
                });

            modelBuilder.Entity("StoreT.Models.FirmPhones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameFirm");

                    b.HasKey("Id");

                    b.ToTable("Firms");
                });

            modelBuilder.Entity("StoreT.Models.ImageModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageModelAddress");

                    b.Property<int>("ImageModelId");

                    b.HasKey("Id");

                    b.HasIndex("ImageModelId")
                        .IsUnique();

                    b.ToTable("ImageModels");
                });

            modelBuilder.Entity("StoreT.Models.ImageUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageAddress");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("ImageUser");
                });

            modelBuilder.Entity("StoreT.Models.ModelPhone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FirmId");

                    b.Property<string>("model");

                    b.HasKey("Id");

                    b.HasIndex("FirmId")
                        .IsUnique();

                    b.ToTable("ModelPhones");
                });

            modelBuilder.Entity("StoreT.Models.QuantityPhone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QuantId");

                    b.Property<int?>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("QuantId")
                        .IsUnique();

                    b.ToTable("QuantityPhones");
                });

            modelBuilder.Entity("StoreT.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<bool>("Type");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("StoreT.Models.UserCabinet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CabinetId");

                    b.Property<string>("QuantityOrders");

                    b.HasKey("Id");

                    b.HasIndex("CabinetId")
                        .IsUnique();

                    b.ToTable("UserCabinets");
                });

            modelBuilder.Entity("StoreT.Models.Charachteristic", b =>
                {
                    b.HasOne("StoreT.Models.ModelPhone", "ModelPhone")
                        .WithOne("Charachteristic")
                        .HasForeignKey("StoreT.Models.Charachteristic", "ModelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StoreT.Models.ImageModel", b =>
                {
                    b.HasOne("StoreT.Models.ModelPhone", "ModelPhone")
                        .WithOne("ImageModel")
                        .HasForeignKey("StoreT.Models.ImageModel", "ImageModelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StoreT.Models.ImageUser", b =>
                {
                    b.HasOne("StoreT.Models.User", "Users")
                        .WithOne("ImageUsers")
                        .HasForeignKey("StoreT.Models.ImageUser", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StoreT.Models.ModelPhone", b =>
                {
                    b.HasOne("StoreT.Models.FirmPhones", "FirmPhones")
                        .WithOne("ModelPhone")
                        .HasForeignKey("StoreT.Models.ModelPhone", "FirmId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StoreT.Models.QuantityPhone", b =>
                {
                    b.HasOne("StoreT.Models.ModelPhone", "ModelPhone")
                        .WithOne("QuantityPhone")
                        .HasForeignKey("StoreT.Models.QuantityPhone", "QuantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StoreT.Models.UserCabinet", b =>
                {
                    b.HasOne("StoreT.Models.User", "User")
                        .WithOne("UserCabinet")
                        .HasForeignKey("StoreT.Models.UserCabinet", "CabinetId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
