﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StreamingTools.Data;

#nullable disable

namespace StreamingTools.Migrations
{
    [DbContext(typeof(StreamingDbContext))]
    [Migration("20250411041807_AddVideoTable")]
    partial class AddVideoTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StreamingTools.Data.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SubtitlesUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan?>("TwitchDuration")
                        .HasColumnType("time");

                    b.Property<string>("TwitchId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("TwitchStartTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("YouTubeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("YouTubePublishTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Videos");
                });
#pragma warning restore 612, 618
        }
    }
}
