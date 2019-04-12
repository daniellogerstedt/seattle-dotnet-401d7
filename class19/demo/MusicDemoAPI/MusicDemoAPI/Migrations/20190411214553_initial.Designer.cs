﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicDemoAPI.Data;

namespace MusicDemoAPI.Migrations
{
    [DbContext(typeof(MusicDbContext))]
    [Migration("20190411214553_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MusicDemoAPI.Models.Artist", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Taylor Swift"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Arianna Grande"
                        });
                });

            modelBuilder.Entity("MusicDemoAPI.Models.Song", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistID");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("ArtistID");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ArtistID = 1,
                            Title = "Shake it Off"
                        },
                        new
                        {
                            ID = 2,
                            ArtistID = 1,
                            Title = "Gorgeous"
                        },
                        new
                        {
                            ID = 3,
                            ArtistID = 1,
                            Title = "22"
                        },
                        new
                        {
                            ID = 4,
                            ArtistID = 2,
                            Title = "Thank You, Next"
                        },
                        new
                        {
                            ID = 5,
                            ArtistID = 2,
                            Title = "7 Rings"
                        });
                });

            modelBuilder.Entity("MusicDemoAPI.Models.Song", b =>
                {
                    b.HasOne("MusicDemoAPI.Models.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
