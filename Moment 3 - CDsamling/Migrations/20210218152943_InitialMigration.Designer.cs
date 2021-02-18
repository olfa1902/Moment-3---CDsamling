﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Moment_3___CDsamling.data;

namespace Moment_3___CDsamling.Migrations
{
    [DbContext(typeof(CDContext))]
    [Migration("20210218152943_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("Moment_3___CDsamling.Models.CDskivor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Album")
                        .HasColumnType("TEXT");

                    b.Property<string>("Artist")
                        .HasColumnType("TEXT");

                    b.Property<int>("Utgivning")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("CDskivor");
                });
#pragma warning restore 612, 618
        }
    }
}
