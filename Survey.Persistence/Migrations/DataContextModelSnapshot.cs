﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Survey.Persistence;

#nullable disable

namespace Survey.Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Survey.Domain.Models.Survey", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Author")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Surveys");
                });

            modelBuilder.Entity("Survey.Domain.Models.SurveyItem", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("SurveyId")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("SurveyId");

                    b.ToTable("SurveyItem");
                });

            modelBuilder.Entity("Survey.Domain.Models.SurveyItemOption", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("SurveyItemId")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("SurveyItemId");

                    b.ToTable("SurveyItemOption");
                });

            modelBuilder.Entity("Survey.Domain.Models.SurveyItem", b =>
                {
                    b.HasOne("Survey.Domain.Models.Survey", null)
                        .WithMany("Items")
                        .HasForeignKey("SurveyId");
                });

            modelBuilder.Entity("Survey.Domain.Models.SurveyItemOption", b =>
                {
                    b.HasOne("Survey.Domain.Models.SurveyItem", null)
                        .WithMany("Options")
                        .HasForeignKey("SurveyItemId");
                });

            modelBuilder.Entity("Survey.Domain.Models.Survey", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Survey.Domain.Models.SurveyItem", b =>
                {
                    b.Navigation("Options");
                });
#pragma warning restore 612, 618
        }
    }
}
