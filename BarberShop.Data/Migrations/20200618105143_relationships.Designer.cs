﻿// <auto-generated />
using BarberShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BarberShop.Data.Migrations
{
    [DbContext(typeof(BarberShopContext))]
    [Migration("20200618105143_relationships")]
    partial class relationships
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BarberShop.Domain.HairStyle", b =>
                {
                    b.Property<int>("HairStyleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HairStylesName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HairStyleId");

                    b.ToTable("Hairs");
                });

            modelBuilder.Entity("BarberShop.Domain.HairStylePrices", b =>
                {
                    b.Property<int>("HairStyleId")
                        .HasColumnType("int");

                    b.Property<int>("PricesId")
                        .HasColumnType("int");

                    b.HasKey("HairStyleId", "PricesId");

                    b.HasIndex("PricesId");

                    b.ToTable("HairStylePrices");
                });

            modelBuilder.Entity("BarberShop.Domain.Prices", b =>
                {
                    b.Property<int>("PricesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HairPrices")
                        .HasColumnType("int");

                    b.HasKey("PricesId");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("BarberShop.Domain.HairStylePrices", b =>
                {
                    b.HasOne("BarberShop.Domain.HairStyle", null)
                        .WithMany("HairStylePrices")
                        .HasForeignKey("HairStyleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BarberShop.Domain.Prices", null)
                        .WithMany("HairStylePrices")
                        .HasForeignKey("PricesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}