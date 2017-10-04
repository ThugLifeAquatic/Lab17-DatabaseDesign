﻿// <auto-generated />
using Lab17DatabaseDesign.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Lab17DatabaseDesign.Migrations
{
    [DbContext(typeof(Lab17DatabaseDesignContext))]
    [Migration("20171004175344_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lab17DatabaseDesign.Models.Destination", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Distance");

                    b.Property<string>("LocationName");

                    b.Property<string>("PosterPath");

                    b.HasKey("ID");

                    b.ToTable("Destination");
                });
#pragma warning restore 612, 618
        }
    }
}
