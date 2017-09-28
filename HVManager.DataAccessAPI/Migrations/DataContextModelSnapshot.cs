﻿// <auto-generated />
using HVManager.DataAccessAPI.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace HVManager.DataAccessAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HVManager.DataAccessAPI.Models.BaseHost", b =>
                {
                    b.Property<int>("HostID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.HasKey("HostID");

                    b.ToTable("Hosts");

                    b.HasDiscriminator<string>("Discriminator").HasValue("BaseHost");
                });

            modelBuilder.Entity("HVManager.DataAccessAPI.Models.PhysicalHost", b =>
                {
                    b.HasBaseType("HVManager.DataAccessAPI.Models.BaseHost");

                    b.Property<int>("CoresPerSocket");

                    b.Property<int>("Sockets");

                    b.ToTable("PhysicalHost");

                    b.HasDiscriminator().HasValue("PhysicalHost");
                });

            modelBuilder.Entity("HVManager.DataAccessAPI.Models.VirtualHost", b =>
                {
                    b.HasBaseType("HVManager.DataAccessAPI.Models.BaseHost");

                    b.Property<int>("CPU");

                    b.ToTable("VirtualHost");

                    b.HasDiscriminator().HasValue("VirtualHost");
                });
#pragma warning restore 612, 618
        }
    }
}
