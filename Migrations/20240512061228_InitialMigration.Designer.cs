﻿// <auto-generated />
using InternProfile.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InternProfile.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240512061228_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("InternProfile.Profile", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Accomplishments")
                        .HasColumnType("TEXT");

                    b.Property<string>("AssignedTeam")
                        .HasColumnType("TEXT");

                    b.Property<string>("CvUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Evalution1Feedback")
                        .HasColumnType("TEXT");

                    b.Property<float>("Evalution1Score")
                        .HasColumnType("REAL");

                    b.Property<string>("Evalution2Feedback")
                        .HasColumnType("TEXT");

                    b.Property<float>("Evalution2Score")
                        .HasColumnType("REAL");

                    b.Property<float>("Gpa")
                        .HasColumnType("REAL");

                    b.Property<string>("InterviewFeedback")
                        .HasColumnType("TEXT");

                    b.Property<float>("InterviewScore")
                        .HasColumnType("REAL");

                    b.Property<string>("MentorId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("PofileStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProjectDetails")
                        .HasColumnType("TEXT");

                    b.Property<string>("University")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Profiles", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
