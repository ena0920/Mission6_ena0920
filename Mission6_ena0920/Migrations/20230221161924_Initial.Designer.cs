﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6_ena0920.Models;

namespace Mission6_ena0920.Migrations
{
    [DbContext(typeof(MovieCollectionContext))]
    [Migration("20230221161924_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission6_ena0920.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("ApplicationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("ApplicationID");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            ApplicationID = 1,
                            Category = "Fantasy",
                            Director = "Jared Bush",
                            Edited = false,
                            LentTo = "Emma Antonucci",
                            Rating = "PG",
                            Title = "Encanto",
                            Year = (ushort)2021
                        },
                        new
                        {
                            ApplicationID = 2,
                            Category = "Crime Comedy",
                            Director = "Ethan Coen",
                            Edited = false,
                            LentTo = "Camilla Antonucci",
                            Rating = "PG-13",
                            Title = "Raising Arizona",
                            Year = (ushort)1987
                        },
                        new
                        {
                            ApplicationID = 3,
                            Category = "Biographical",
                            Director = "Theodore Melfi",
                            Edited = false,
                            LentTo = "Kayla Antonucci",
                            Rating = "PG-13",
                            Title = "Hidden Figures",
                            Year = (ushort)2017
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
