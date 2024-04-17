﻿// <auto-generated />
using BookBazaar.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookBazaar.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240417142401_SeedCategoryTable")]
    partial class SeedCategoryTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookBazaar.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Cooking"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Self-Help"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Adventure"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
