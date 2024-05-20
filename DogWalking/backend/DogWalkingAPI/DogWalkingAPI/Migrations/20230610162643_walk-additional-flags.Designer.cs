﻿// <auto-generated />
using System;
using DogWalkingAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DogWalkingAPI.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20230610162643_walk-additional-flags")]
    partial class walkadditionalflags
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DogWalk", b =>
                {
                    b.Property<int>("DogsDogId")
                        .HasColumnType("int");

                    b.Property<int>("WalksWalkId")
                        .HasColumnType("int");

                    b.HasKey("DogsDogId", "WalksWalkId");

                    b.HasIndex("WalksWalkId");

                    b.ToTable("DogWalk");
                });

            modelBuilder.Entity("DogWalkingAPI.Model.Availability", b =>
                {
                    b.Property<int>("AvailabilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AvailabilityId"));

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<double>("Radius")
                        .HasColumnType("float");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("WalkerId")
                        .HasColumnType("int");

                    b.HasKey("AvailabilityId");

                    b.HasIndex("UserId");

                    b.ToTable("Availabilities");
                });

            modelBuilder.Entity("DogWalkingAPI.Model.Dog", b =>
                {
                    b.Property<int>("DogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DogId"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("DogId");

                    b.HasIndex("UserId");

                    b.ToTable("Dogs");
                });

            modelBuilder.Entity("DogWalkingAPI.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NrOfWalks")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("RatePerHour")
                        .HasColumnType("float");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DogWalkingAPI.Model.Walk", b =>
                {
                    b.Property<int>("WalkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WalkId"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAwaitingPayment")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDone")
                        .HasColumnType("bit");

                    b.Property<bool>("IsStarted")
                        .HasColumnType("bit");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("WalkerId")
                        .HasColumnType("int");

                    b.HasKey("WalkId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("WalkerId");

                    b.ToTable("Walks");
                });

            modelBuilder.Entity("DogWalk", b =>
                {
                    b.HasOne("DogWalkingAPI.Model.Dog", null)
                        .WithMany()
                        .HasForeignKey("DogsDogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DogWalkingAPI.Model.Walk", null)
                        .WithMany()
                        .HasForeignKey("WalksWalkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DogWalkingAPI.Model.Availability", b =>
                {
                    b.HasOne("DogWalkingAPI.Model.User", null)
                        .WithMany("Availabilities")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("DogWalkingAPI.Model.Dog", b =>
                {
                    b.HasOne("DogWalkingAPI.Model.User", null)
                        .WithMany("Dogs")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("DogWalkingAPI.Model.Walk", b =>
                {
                    b.HasOne("DogWalkingAPI.Model.User", "Owner")
                        .WithMany("OwnerWalks")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DogWalkingAPI.Model.User", "Walker")
                        .WithMany("WalkerWalks")
                        .HasForeignKey("WalkerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("Walker");
                });

            modelBuilder.Entity("DogWalkingAPI.Model.User", b =>
                {
                    b.Navigation("Availabilities");

                    b.Navigation("Dogs");

                    b.Navigation("OwnerWalks");

                    b.Navigation("WalkerWalks");
                });
#pragma warning restore 612, 618
        }
    }
}
