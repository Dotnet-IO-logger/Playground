﻿// <auto-generated />
using System;
using Example3EntityFrameworkLoggingSample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Example3EntityFrameworkLoggingSample.Migrations
{
    [DbContext(typeof(DiolDbContext))]
    [Migration("20240818094703_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("Example3EntityFrameworkLoggingSample.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("State")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Example3EntityFrameworkLoggingSample.Models.EventLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EventNameId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EventNameId");

                    b.ToTable("EventLogs");
                });

            modelBuilder.Entity("Example3EntityFrameworkLoggingSample.Models.EventName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("EventNames");
                });

            modelBuilder.Entity("Example3EntityFrameworkLoggingSample.Models.EventLog", b =>
                {
                    b.HasOne("Example3EntityFrameworkLoggingSample.Models.EventName", "EventName")
                        .WithMany()
                        .HasForeignKey("EventNameId");

                    b.Navigation("EventName");
                });

            modelBuilder.Entity("Example3EntityFrameworkLoggingSample.Models.EventName", b =>
                {
                    b.HasOne("Example3EntityFrameworkLoggingSample.Models.Category", "Category")
                        .WithMany("EventNames")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Example3EntityFrameworkLoggingSample.Models.Category", b =>
                {
                    b.Navigation("EventNames");
                });
#pragma warning restore 612, 618
        }
    }
}
