﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GainsIndex.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220823011219_splitdaybools")]
    partial class splitdaybools
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("Exercise", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("bella_friday")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("bella_monday")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("bella_saturday")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("bella_sunday")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("bella_thursday")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("bella_tuesday")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("bella_wednesday")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("body_focus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("details")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("exercise_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("exercise_type")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("geo_friday")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("geo_monday")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("geo_saturday")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("geo_sunday")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("geo_thursday")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("geo_tuesday")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("geo_wednesday")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("motion_group")
                        .HasColumnType("INTEGER");

                    b.Property<int>("reps")
                        .HasColumnType("INTEGER");

                    b.Property<int>("sets")
                        .HasColumnType("INTEGER");

                    b.Property<string>("target_muscle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ww_bella")
                        .HasColumnType("TEXT");

                    b.Property<string>("ww_geo")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Exercises");
                });
#pragma warning restore 612, 618
        }
    }
}
