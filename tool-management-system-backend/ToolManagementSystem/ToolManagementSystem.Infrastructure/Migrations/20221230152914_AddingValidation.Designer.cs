﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToolManagementSystem.Infrastructure.Data;

#nullable disable

namespace ToolManagementSystem.Infrastructure.Migrations
{
    [DbContext(typeof(ToolStoreDbContext))]
    [Migration("20221230152914_AddingValidation")]
    partial class AddingValidation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .HasMaxLength(6)
                        .HasColumnType("TEXT");

                    b.Property<string>("EngineType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ManufacturerSerialNumber")
                        .HasMaxLength(5)
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Aircrafts");
                });
#pragma warning restore 612, 618
        }
    }
}
