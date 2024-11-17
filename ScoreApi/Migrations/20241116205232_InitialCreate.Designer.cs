﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScoreApi.Models;

#nullable disable

namespace ScoreApi.Migrations
{
    [DbContext(typeof(ScoreContext))]
    [Migration("20241116205232_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("ScoreApi.Models.Board", b =>
                {
                    b.Property<int>("BoardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BoardId");

                    b.ToTable("Boards");
                });
#pragma warning restore 612, 618
        }
    }
}