﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using StudentsData.Models;
using System;

namespace StudentsData.Migrations
{
    [DbContext(typeof(StudentsDataContext))]
    partial class StudentsDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentsData.Models.FatherDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Class");

                    b.Property<string>("FatherName");

                    b.Property<int?>("StudentsId");

                    b.HasKey("Id");

                    b.HasIndex("StudentsId");

                    b.ToTable("FatherDetail");
                });

            modelBuilder.Entity("StudentsData.Models.Students", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Class");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentsData.Models.FatherDetail", b =>
                {
                    b.HasOne("StudentsData.Models.Students")
                        .WithMany("Father")
                        .HasForeignKey("StudentsId");
                });
#pragma warning restore 612, 618
        }
    }
}
