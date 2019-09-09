﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlantIterationOne.Web.Data;

namespace PlantIterationOne.Web.Migrations
{
    [DbContext(typeof(PlantContext))]
    [Migration("20190828025012_InitialTwo")]
    partial class InitialTwo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PlantIterationOne.Web.Model.Invasive", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Colour");

                    b.Property<string>("Habitat");

                    b.Property<string>("Impacts");

                    b.Property<string>("Name");

                    b.Property<string>("Origin");

                    b.Property<string>("ScientificName");

                    b.Property<string>("Spreads");

                    b.Property<string>("WeedControl");

                    b.HasKey("Id");

                    b.ToTable("Invasives");
                });

            modelBuilder.Entity("PlantIterationOne.Web.Model.Native", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BotanicalName");

                    b.Property<string>("Colour");

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.Property<string>("SoilTexture");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Natives");
                });
#pragma warning restore 612, 618
        }
    }
}