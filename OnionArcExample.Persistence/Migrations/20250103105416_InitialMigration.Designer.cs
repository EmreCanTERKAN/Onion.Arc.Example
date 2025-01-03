﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnionArcExample.Persistence.Context;

#nullable disable

namespace OnionArcExample.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250103105416_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OnionArcExample.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0a840032-c3e6-4981-b49d-1c66df5c3ccc"),
                            Description = "Product 1 Description",
                            Name = "Product 1",
                            Price = 1000,
                            Stock = 10
                        },
                        new
                        {
                            Id = new Guid("a124d6ae-4493-4e67-9b50-c633ccc076e8"),
                            Description = "Product 2 Description",
                            Name = "Product 2",
                            Price = 2000,
                            Stock = 20
                        },
                        new
                        {
                            Id = new Guid("387b2bdf-787a-4777-9d4d-f63e0c6c16e6"),
                            Description = "Product 3 Description",
                            Name = "Product 3",
                            Price = 3000,
                            Stock = 30
                        },
                        new
                        {
                            Id = new Guid("e1dc46a0-1a05-4c66-84aa-bc1e8d749a5b"),
                            Description = "Product 4 Description",
                            Name = "Product 4",
                            Price = 4000,
                            Stock = 40
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
