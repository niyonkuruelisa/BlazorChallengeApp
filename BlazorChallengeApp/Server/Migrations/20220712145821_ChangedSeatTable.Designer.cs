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
    [Migration("20220712145821_ChangedSeatTable")]
    partial class ChangedSeatTable
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
                        .IsRequired()
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

                    b.Property<Guid?>("BookingId")
                        .HasColumnType("TEXT");

                    b.Property<int>("column")
                        .HasColumnType("INTEGER");

                    b.Property<int>("row")
                        .HasColumnType("INTEGER");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("BookingId");

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
                            Id = "22254ace-3c48-4aa6-9bd7-481f1cfe4c14",
                            _price = 10.0,
                            _ticketName = "ADULT"
                        },
                        new
                        {
                            Id = "c14e06aa-c32b-4da1-b3f0-3b02608c74cc",
                            _price = 10.0,
                            _ticketName = "CHILD (AGE 14 AND UNDER)"
                        },
                        new
                        {
                            Id = "1360f471-00f0-48d8-bbfe-444de705210a",
                            _price = 32.0,
                            _ticketName = "FAMILY X 4(2 AD + 2CH OR 1AD +3 CH)"
                        },
                        new
                        {
                            Id = "8fb84006-a89d-4e5d-b7dd-6a587e86b366",
                            _price = 8.5,
                            _ticketName = "STUDENT"
                        },
                        new
                        {
                            Id = "a326aa38-5e26-46ad-94da-9943de234aa1",
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
                        .HasForeignKey("BookingId");
                });

            modelBuilder.Entity("BlazorChallengeApp.Shared.Booking", b =>
                {
                    b.Navigation("seats");
                });
#pragma warning restore 612, 618
        }
    }
}
