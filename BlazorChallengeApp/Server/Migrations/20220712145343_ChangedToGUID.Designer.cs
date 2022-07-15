﻿// <auto-generated />
using System;
using BlazorChallengeApp.Server.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorChallengeApp.Server.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20220712145343_ChangedToGUID")]
    partial class ChangedToGUID
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("BlazorChallengeApp.Shared.Booking", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("day")
                        .HasColumnType("TEXT");

                    b.Property<int?>("movieId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("time")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("BlazorChallengeApp.Shared.Movie", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cast")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("RunningTimesId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RunningTimesId");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("BlazorChallengeApp.Shared.RunningTimes", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Fri")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mon")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sat")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sun")
                        .HasColumnType("TEXT");

                    b.Property<string>("Thu")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tue")
                        .HasColumnType("TEXT");

                    b.Property<string>("Wed")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("RunningTimes");
                });

            modelBuilder.Entity("BlazorChallengeApp.Shared.Seat", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("TEXT");

                    b.Property<string>("BookingId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("BookingId1")
                        .HasColumnType("TEXT");

                    b.Property<int>("column")
                        .HasColumnType("INTEGER");

                    b.Property<int>("row")
                        .HasColumnType("INTEGER");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("BookingId1");

                    b.ToTable("Seat");
                });

            modelBuilder.Entity("BlazorChallengeApp.Shared.Ticket", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<double>("_price")
                        .HasColumnType("REAL");

                    b.Property<string>("_ticketName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Ticket");

                    b.HasData(
                        new
                        {
                            Id = "25f2b95b-5b5d-4458-8e1f-3c8c1623a47f",
                            _price = 10.0,
                            _ticketName = "ADULT"
                        },
                        new
                        {
                            Id = "4f8c1c2b-9c0e-48e9-a6f5-4d4a7f082f13",
                            _price = 10.0,
                            _ticketName = "CHILD (AGE 14 AND UNDER)"
                        },
                        new
                        {
                            Id = "0e5be183-21e7-480c-81a8-2cd1aa085fda",
                            _price = 32.0,
                            _ticketName = "FAMILY X 4(2 AD + 2CH OR 1AD +3 CH)"
                        },
                        new
                        {
                            Id = "50bdfc3f-c240-4e44-b668-1ade98e10c06",
                            _price = 8.5,
                            _ticketName = "STUDENT"
                        },
                        new
                        {
                            Id = "054082f3-5a14-4434-8370-6e39533a0245",
                            _price = 8.5,
                            _ticketName = "SENIOR(65 & OVER)"
                        });
                });

            modelBuilder.Entity("BlazorChallengeApp.Shared.Movie", b =>
                {
                    b.HasOne("BlazorChallengeApp.Shared.RunningTimes", "RunningTimes")
                        .WithMany()
                        .HasForeignKey("RunningTimesId");

                    b.Navigation("RunningTimes");
                });

            modelBuilder.Entity("BlazorChallengeApp.Shared.Seat", b =>
                {
                    b.HasOne("BlazorChallengeApp.Shared.Booking", null)
                        .WithMany("seats")
                        .HasForeignKey("BookingId1");
                });

            modelBuilder.Entity("BlazorChallengeApp.Shared.Booking", b =>
                {
                    b.Navigation("seats");
                });
#pragma warning restore 612, 618
        }
    }
}
