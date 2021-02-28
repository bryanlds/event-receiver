﻿// <auto-generated />
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("Domain.Entities.SensorEventAggregate.SensorEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Data")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("Valor");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT")
                        .HasColumnName("Status");

                    b.Property<string>("Timestamp")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT")
                        .HasColumnName("Timestamp");

                    b.HasKey("Id");

                    b.ToTable("SensorEvent");
                });

            modelBuilder.Entity("Domain.Entities.SensorEventAggregate.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("Country");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("Region");

                    b.Property<int>("SensorEventId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SensorName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("SensorName");

                    b.HasKey("Id");

                    b.HasIndex("SensorEventId")
                        .IsUnique();

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("Domain.Entities.SensorEventAggregate.Tag", b =>
                {
                    b.HasOne("Domain.Entities.SensorEventAggregate.SensorEvent", "SensorEvent")
                        .WithOne("Tag")
                        .HasForeignKey("Domain.Entities.SensorEventAggregate.Tag", "SensorEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SensorEvent");
                });

            modelBuilder.Entity("Domain.Entities.SensorEventAggregate.SensorEvent", b =>
                {
                    b.Navigation("Tag");
                });
#pragma warning restore 612, 618
        }
    }
}
