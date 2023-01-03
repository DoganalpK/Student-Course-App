﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentCourseApp.Persistence.Contexts;

#nullable disable

namespace StudentCourseApp.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230103134417_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StudentCourseApp.Domain.Entities.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolNumber")
                        .HasColumnType("int");

                    b.Property<Guid>("StudentClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StudentClassId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentCourseApp.Domain.Entities.StudentClass", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClassLetter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClassNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StudentClass");
                });

            modelBuilder.Entity("StudentCourseApp.Domain.Entities.Student", b =>
                {
                    b.HasOne("StudentCourseApp.Domain.Entities.StudentClass", "StudentClass")
                        .WithMany("Students")
                        .HasForeignKey("StudentClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StudentClass");
                });

            modelBuilder.Entity("StudentCourseApp.Domain.Entities.StudentClass", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
