﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pizzeria.Data;

namespace Pizzeria.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210327102852_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("Pizzeria.Models.Addition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Additions");
                });

            modelBuilder.Entity("Pizzeria.Models.AdditionOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AdditionId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FoodOrderId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AdditionId");

                    b.HasIndex("FoodOrderId");

                    b.ToTable("AdditionOrders");
                });

            modelBuilder.Entity("Pizzeria.Models.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Food");
                });

            modelBuilder.Entity("Pizzeria.Models.FoodCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FoodCategories");
                });

            modelBuilder.Entity("Pizzeria.Models.FoodOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DishId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OrderId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DishId");

                    b.HasIndex("OrderId");

                    b.ToTable("FoodOrders");
                });

            modelBuilder.Entity("Pizzeria.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Note")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Pizzeria.Models.Addition", b =>
                {
                    b.HasOne("Pizzeria.Models.FoodCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Pizzeria.Models.AdditionOrder", b =>
                {
                    b.HasOne("Pizzeria.Models.Addition", "Addition")
                        .WithMany()
                        .HasForeignKey("AdditionId");

                    b.HasOne("Pizzeria.Models.FoodOrder", null)
                        .WithMany("AdditionOrders")
                        .HasForeignKey("FoodOrderId");

                    b.Navigation("Addition");
                });

            modelBuilder.Entity("Pizzeria.Models.Food", b =>
                {
                    b.HasOne("Pizzeria.Models.FoodCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Pizzeria.Models.FoodOrder", b =>
                {
                    b.HasOne("Pizzeria.Models.Food", "Dish")
                        .WithMany()
                        .HasForeignKey("DishId");

                    b.HasOne("Pizzeria.Models.Order", null)
                        .WithMany("FoodOrders")
                        .HasForeignKey("OrderId");

                    b.Navigation("Dish");
                });

            modelBuilder.Entity("Pizzeria.Models.FoodOrder", b =>
                {
                    b.Navigation("AdditionOrders");
                });

            modelBuilder.Entity("Pizzeria.Models.Order", b =>
                {
                    b.Navigation("FoodOrders");
                });
#pragma warning restore 612, 618
        }
    }
}