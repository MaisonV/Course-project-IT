﻿// <auto-generated />
using System;
using FightMatrix.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FightMatrix.Migrations
{
    [DbContext(typeof(FightMatrixContext))]
    partial class FightMatrixContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FightMatrix.Models.Fighter", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DebutDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Draws")
                        .HasColumnType("int");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("L5Draws")
                        .HasColumnType("int");

                    b.Property<int>("L5Loses")
                        .HasColumnType("int");

                    b.Property<int>("L5NC")
                        .HasColumnType("int");

                    b.Property<int>("L5Wins")
                        .HasColumnType("int");

                    b.Property<int>("Loses")
                        .HasColumnType("int");

                    b.Property<int>("NC")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Promotion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RatingPoints")
                        .HasColumnType("int");

                    b.Property<int>("Wins")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Fighter");
                });
#pragma warning restore 612, 618
        }
    }
}
