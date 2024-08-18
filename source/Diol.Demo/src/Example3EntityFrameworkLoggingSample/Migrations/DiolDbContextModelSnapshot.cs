﻿// <auto-generated />
using System;
using Example3EntityFrameworkLoggingSample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Example3EntityFrameworkLoggingSample.Migrations
{
    [DbContext(typeof(DiolDbContext))]
    partial class DiolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "HttpClient",
                            State = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Aspnet",
                            State = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "EntityFramework",
                            State = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "WebSockets",
                            State = 0
                        },
                        new
                        {
                            Id = 5,
                            Name = "gRPC",
                            State = 0
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EventNameId = 7
                        },
                        new
                        {
                            Id = 2,
                            EventNameId = 4
                        },
                        new
                        {
                            Id = 3,
                            EventNameId = 3
                        },
                        new
                        {
                            Id = 4,
                            EventNameId = 10
                        },
                        new
                        {
                            Id = 5,
                            EventNameId = 11
                        },
                        new
                        {
                            Id = 6,
                            EventNameId = 1
                        },
                        new
                        {
                            Id = 7,
                            EventNameId = 5
                        },
                        new
                        {
                            Id = 8,
                            EventNameId = 3
                        },
                        new
                        {
                            Id = 9,
                            EventNameId = 9
                        },
                        new
                        {
                            Id = 10,
                            EventNameId = 9
                        },
                        new
                        {
                            Id = 11,
                            EventNameId = 1
                        },
                        new
                        {
                            Id = 12,
                            EventNameId = 2
                        },
                        new
                        {
                            Id = 13,
                            EventNameId = 3
                        },
                        new
                        {
                            Id = 14,
                            EventNameId = 1
                        },
                        new
                        {
                            Id = 15,
                            EventNameId = 3
                        },
                        new
                        {
                            Id = 16,
                            EventNameId = 5
                        },
                        new
                        {
                            Id = 17,
                            EventNameId = 11
                        },
                        new
                        {
                            Id = 18,
                            EventNameId = 1
                        },
                        new
                        {
                            Id = 19,
                            EventNameId = 4
                        },
                        new
                        {
                            Id = 20,
                            EventNameId = 3
                        },
                        new
                        {
                            Id = 21,
                            EventNameId = 2
                        },
                        new
                        {
                            Id = 22,
                            EventNameId = 8
                        },
                        new
                        {
                            Id = 23,
                            EventNameId = 10
                        },
                        new
                        {
                            Id = 24,
                            EventNameId = 6
                        },
                        new
                        {
                            Id = 25,
                            EventNameId = 6
                        },
                        new
                        {
                            Id = 26,
                            EventNameId = 2
                        },
                        new
                        {
                            Id = 27,
                            EventNameId = 11
                        },
                        new
                        {
                            Id = 28,
                            EventNameId = 9
                        },
                        new
                        {
                            Id = 29,
                            EventNameId = 4
                        },
                        new
                        {
                            Id = 30,
                            EventNameId = 6
                        },
                        new
                        {
                            Id = 31,
                            EventNameId = 2
                        },
                        new
                        {
                            Id = 32,
                            EventNameId = 7
                        },
                        new
                        {
                            Id = 33,
                            EventNameId = 8
                        },
                        new
                        {
                            Id = 34,
                            EventNameId = 2
                        },
                        new
                        {
                            Id = 35,
                            EventNameId = 10
                        },
                        new
                        {
                            Id = 36,
                            EventNameId = 9
                        },
                        new
                        {
                            Id = 37,
                            EventNameId = 4
                        },
                        new
                        {
                            Id = 38,
                            EventNameId = 3
                        },
                        new
                        {
                            Id = 39,
                            EventNameId = 6
                        },
                        new
                        {
                            Id = 40,
                            EventNameId = 1
                        },
                        new
                        {
                            Id = 41,
                            EventNameId = 7
                        },
                        new
                        {
                            Id = 42,
                            EventNameId = 2
                        },
                        new
                        {
                            Id = 43,
                            EventNameId = 3
                        },
                        new
                        {
                            Id = 44,
                            EventNameId = 3
                        },
                        new
                        {
                            Id = 45,
                            EventNameId = 2
                        },
                        new
                        {
                            Id = 46,
                            EventNameId = 3
                        },
                        new
                        {
                            Id = 47,
                            EventNameId = 10
                        },
                        new
                        {
                            Id = 48,
                            EventNameId = 8
                        },
                        new
                        {
                            Id = 49,
                            EventNameId = 11
                        },
                        new
                        {
                            Id = 50,
                            EventNameId = 1
                        },
                        new
                        {
                            Id = 51,
                            EventNameId = 4
                        },
                        new
                        {
                            Id = 52,
                            EventNameId = 2
                        },
                        new
                        {
                            Id = 53,
                            EventNameId = 3
                        },
                        new
                        {
                            Id = 54,
                            EventNameId = 4
                        },
                        new
                        {
                            Id = 55,
                            EventNameId = 6
                        },
                        new
                        {
                            Id = 56,
                            EventNameId = 1
                        },
                        new
                        {
                            Id = 57,
                            EventNameId = 10
                        },
                        new
                        {
                            Id = 58,
                            EventNameId = 5
                        },
                        new
                        {
                            Id = 59,
                            EventNameId = 3
                        },
                        new
                        {
                            Id = 60,
                            EventNameId = 6
                        },
                        new
                        {
                            Id = 61,
                            EventNameId = 9
                        },
                        new
                        {
                            Id = 62,
                            EventNameId = 10
                        },
                        new
                        {
                            Id = 63,
                            EventNameId = 8
                        },
                        new
                        {
                            Id = 64,
                            EventNameId = 2
                        },
                        new
                        {
                            Id = 65,
                            EventNameId = 1
                        },
                        new
                        {
                            Id = 66,
                            EventNameId = 7
                        },
                        new
                        {
                            Id = 67,
                            EventNameId = 8
                        },
                        new
                        {
                            Id = 68,
                            EventNameId = 2
                        },
                        new
                        {
                            Id = 69,
                            EventNameId = 5
                        },
                        new
                        {
                            Id = 70,
                            EventNameId = 6
                        },
                        new
                        {
                            Id = 71,
                            EventNameId = 11
                        },
                        new
                        {
                            Id = 72,
                            EventNameId = 6
                        },
                        new
                        {
                            Id = 73,
                            EventNameId = 1
                        },
                        new
                        {
                            Id = 74,
                            EventNameId = 3
                        },
                        new
                        {
                            Id = 75,
                            EventNameId = 1
                        },
                        new
                        {
                            Id = 76,
                            EventNameId = 4
                        },
                        new
                        {
                            Id = 77,
                            EventNameId = 7
                        },
                        new
                        {
                            Id = 78,
                            EventNameId = 3
                        },
                        new
                        {
                            Id = 79,
                            EventNameId = 10
                        },
                        new
                        {
                            Id = 80,
                            EventNameId = 3
                        },
                        new
                        {
                            Id = 81,
                            EventNameId = 9
                        },
                        new
                        {
                            Id = 82,
                            EventNameId = 6
                        },
                        new
                        {
                            Id = 83,
                            EventNameId = 5
                        },
                        new
                        {
                            Id = 84,
                            EventNameId = 3
                        },
                        new
                        {
                            Id = 85,
                            EventNameId = 6
                        },
                        new
                        {
                            Id = 86,
                            EventNameId = 9
                        },
                        new
                        {
                            Id = 87,
                            EventNameId = 11
                        },
                        new
                        {
                            Id = 88,
                            EventNameId = 6
                        },
                        new
                        {
                            Id = 89,
                            EventNameId = 5
                        },
                        new
                        {
                            Id = 90,
                            EventNameId = 4
                        },
                        new
                        {
                            Id = 91,
                            EventNameId = 10
                        },
                        new
                        {
                            Id = 92,
                            EventNameId = 2
                        },
                        new
                        {
                            Id = 93,
                            EventNameId = 5
                        },
                        new
                        {
                            Id = 94,
                            EventNameId = 10
                        },
                        new
                        {
                            Id = 95,
                            EventNameId = 3
                        },
                        new
                        {
                            Id = 96,
                            EventNameId = 3
                        },
                        new
                        {
                            Id = 97,
                            EventNameId = 4
                        },
                        new
                        {
                            Id = 98,
                            EventNameId = 3
                        },
                        new
                        {
                            Id = 99,
                            EventNameId = 4
                        },
                        new
                        {
                            Id = 100,
                            EventNameId = 8
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "RequestPipelineStartDto"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Name = "RequestPipelineRequestHeaderDto"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Name = "RequestPipelineEndDto"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Name = "RequestPipelineResponseHeaderDto"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Name = "RequestLogDto"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Name = "RequestBodyDto"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Name = "ResponseLogDto"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Name = "ResponseBodyDto"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Name = "ConnectionOpeningDto"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Name = "CommandExecutingDto"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Name = "CommandExecutedDto"
                        });
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
