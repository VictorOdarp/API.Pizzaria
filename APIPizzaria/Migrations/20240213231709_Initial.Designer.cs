﻿// <auto-generated />
using APIPizzaria.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIPizzaria.Migrations
{
    [DbContext(typeof(DarpinosDbContext))]
    [Migration("20240213231709_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("APIPizzaria.Models.BebidaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Nome")
                        .HasColumnType("int");

                    b.Property<double>("Preço")
                        .HasColumnType("double");

                    b.Property<int>("Tamanho")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Bebida");
                });

            modelBuilder.Entity("APIPizzaria.Models.PizzaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Borda")
                        .HasColumnType("int");

                    b.Property<double>("Preço")
                        .HasColumnType("double");

                    b.Property<int>("Sabor")
                        .HasColumnType("int");

                    b.Property<int>("Tamanho")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pizza");
                });
#pragma warning restore 612, 618
        }
    }
}