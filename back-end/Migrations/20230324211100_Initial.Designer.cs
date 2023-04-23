﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model;

#nullable disable

namespace Albums.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20230324211100_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Model.Album", b =>
                {
                    b.Property<long>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("AlbumId"));

                    b.Property<long?>("ArtistId")
                        .IsRequired()
                        .HasColumnType("bigint");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfTracks")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<long?>("RecordLabelId")
                        .IsRequired()
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YearOFRelease")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlbumId");

                    b.HasIndex("ArtistId");

                    b.HasIndex("RecordLabelId");

                    b.ToTable("Album");
                });

            modelBuilder.Entity("Model.Artist", b =>
                {
                    b.Property<long>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ArtistId"));

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainGenre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtistId");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("Model.Certifications", b =>
                {
                    b.Property<long?>("RecordLabelId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ArtistId")
                        .HasColumnType("bigint");

                    b.Property<string>("Award")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UnitsSold")
                        .HasColumnType("int");

                    b.HasKey("RecordLabelId", "ArtistId");

                    b.HasIndex("ArtistId");

                    b.ToTable("Certifications");
                });

            modelBuilder.Entity("Model.RecordLabel", b =>
                {
                    b.Property<long>("RecordLabelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("RecordLabelId"));

                    b.Property<string>("CEO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfEstablishment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfArtists")
                        .HasColumnType("int");

                    b.HasKey("RecordLabelId");

                    b.ToTable("RecordLabel");
                });

            modelBuilder.Entity("Model.Album", b =>
                {
                    b.HasOne("Model.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.RecordLabel", "RecordLabel")
                        .WithMany("Albums")
                        .HasForeignKey("RecordLabelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("RecordLabel");
                });

            modelBuilder.Entity("Model.Certifications", b =>
                {
                    b.HasOne("Model.Artist", "Artist")
                        .WithMany("Certifications")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.RecordLabel", "RecordLabel")
                        .WithMany("Certifications")
                        .HasForeignKey("RecordLabelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("RecordLabel");
                });

            modelBuilder.Entity("Model.Artist", b =>
                {
                    b.Navigation("Albums");

                    b.Navigation("Certifications");
                });

            modelBuilder.Entity("Model.RecordLabel", b =>
                {
                    b.Navigation("Albums");

                    b.Navigation("Certifications");
                });
#pragma warning restore 612, 618
        }
    }
}
