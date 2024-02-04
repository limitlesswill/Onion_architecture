﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Onion.Infrastructure.Context;

#nullable disable

namespace Onion.Infrastructure.Context.Migrations
{
    [DbContext(typeof(OnionContext))]
    partial class OnionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Onion.Models.Course", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<double?>("duration")
                        .HasColumnType("float");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("course");
                });

            modelBuilder.Entity("Onion.Models.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("student");
                });

            modelBuilder.Entity("Onion.Models.StudentCourse", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("courseid")
                        .HasColumnType("int");

                    b.Property<int?>("studentid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("courseid");

                    b.HasIndex("studentid");

                    b.ToTable("studentCourse");
                });

            modelBuilder.Entity("Onion.Models.StudentCourse", b =>
                {
                    b.HasOne("Onion.Models.Course", "course")
                        .WithMany("StudentCourseList")
                        .HasForeignKey("courseid");

                    b.HasOne("Onion.Models.Student", "student")
                        .WithMany("StudentCourseList")
                        .HasForeignKey("studentid");

                    b.Navigation("course");

                    b.Navigation("student");
                });

            modelBuilder.Entity("Onion.Models.Course", b =>
                {
                    b.Navigation("StudentCourseList");
                });

            modelBuilder.Entity("Onion.Models.Student", b =>
                {
                    b.Navigation("StudentCourseList");
                });
#pragma warning restore 612, 618
        }
    }
}