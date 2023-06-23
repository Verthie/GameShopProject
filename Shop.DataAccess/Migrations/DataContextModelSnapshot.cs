﻿// <auto-generated />
using Shop.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Shop.DataAccess.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.7");

            modelBuilder.Entity("GameShop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Platforming"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Souls-like"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Rouge-lite"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "RPG"
                        },
                        new
                        {
                            Id = 6,
                            DisplayOrder = 6,
                            Name = "MMO"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}