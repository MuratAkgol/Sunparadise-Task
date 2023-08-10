﻿// <auto-generated />
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("EntityLayer.CvTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AdSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Beceriler")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Deneyim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eğitim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sertifikalar")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cv");
                });

            modelBuilder.Entity("EntityLayer.Employer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Eposta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirmaAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirmaHk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employers");
                });

            modelBuilder.Entity("EntityLayer.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CvId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Isim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoyAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}