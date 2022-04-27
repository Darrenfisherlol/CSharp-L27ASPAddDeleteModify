﻿// <auto-generated />
using L27ASPAddDeleteModify.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace L27ASPAddDeleteModify.Migrations
{
    [DbContext(typeof(StuDBContext))]
    [Migration("20220427155850_ND")]
    partial class ND
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("L27ASPAddDeleteModify.Models.Student", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("TEXT");

                    b.Property<double>("grade")
                        .HasColumnType("REAL");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
