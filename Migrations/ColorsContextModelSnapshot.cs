﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using colorsql.Models;

namespace colorsql.Migrations
{
    [DbContext(typeof(ColorsContext))]
    partial class ColorsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932");

            modelBuilder.Entity("colorsql.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Rgb");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("colorsql.Models.Translation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ColorId");

                    b.Property<string>("Language");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.ToTable("Translations");
                });

            modelBuilder.Entity("colorsql.Models.Translation", b =>
                {
                    b.HasOne("colorsql.Models.Color", "Color")
                        .WithMany("translations")
                        .HasForeignKey("ColorId");
                });
#pragma warning restore 612, 618
        }
    }
}
