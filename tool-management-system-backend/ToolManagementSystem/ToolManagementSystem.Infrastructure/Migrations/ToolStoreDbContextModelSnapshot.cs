﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToolManagementSystem.Infrastructure.Data;

#nullable disable

namespace ToolManagementSystem.Infrastructure.Migrations
{
    [DbContext(typeof(ToolStoreDbContext))]
    partial class ToolStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true);

            modelBuilder.Entity("ToolManagementSystem.Domain.Entities.Aircraft", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AircraftRegistration")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EngineType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ManufacturerSerialNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Aircrafts");
                });

            modelBuilder.Entity("ToolManagementSystem.Domain.Entities.Tool", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("TakenById")
                        .HasColumnType("TEXT");

                    b.Property<string>("ToolDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ToolMarking")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TakenById");

                    b.ToTable("Tools");
                });

            modelBuilder.Entity("ToolManagementSystem.Domain.Entities.Toolbox", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ToolboxMarking")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Toolboxes");
                });

            modelBuilder.Entity("ToolManagementSystem.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ThreeLetterCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ToolManagementSystem.Domain.Entities.Tool", b =>
                {
                    b.HasOne("ToolManagementSystem.Domain.Entities.User", "User")
                        .WithMany("UsedTools")
                        .HasForeignKey("TakenById")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("User");
                });

            modelBuilder.Entity("ToolManagementSystem.Domain.Entities.User", b =>
                {
                    b.Navigation("UsedTools");
                });
#pragma warning restore 612, 618
        }
    }
}
