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
    [Migration("20180325135422_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentsData.Models.FatherDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Class");

                    b.Property<string>("FatherName");

                    b.HasKey("Id");

                    b.ToTable("FatherDetail");
                });

            modelBuilder.Entity("StudentsData.Models.Students", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Class");

                    b.Property<int?>("FatherId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("FatherId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentsData.Models.Students", b =>
                {
                    b.HasOne("StudentsData.Models.FatherDetail", "Father")
                        .WithMany()
                        .HasForeignKey("FatherId");
                });
#pragma warning restore 612, 618
        }
    }
}
