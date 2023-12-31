﻿// <auto-generated />
using System;
using HealthCareApplication.Domains.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HealthCareApplication.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230804091557_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HealthCareApplication.Domains.Models.HealthMetric", b =>
                {
                    b.Property<string>("HealthMetricId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("BloodSugar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BodyTemperature")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DiastolicBloodPressure")
                        .HasColumnType("int");

                    b.Property<string>("PersonId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PulseRate")
                        .HasColumnType("int");

                    b.Property<int>("SystolicBloodPressure")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Timestamp")
                        .HasColumnType("time");

                    b.HasKey("HealthMetricId");

                    b.HasIndex("PersonId");

                    b.ToTable("HealthMetrics");
                });

            modelBuilder.Entity("HealthCareApplication.Domains.Models.Person", b =>
                {
                    b.Property<string>("PersonId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("PersonType")
                        .HasColumnType("int");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("PersonPerson", b =>
                {
                    b.Property<string>("PersonId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RelativesPersonId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PersonId", "RelativesPersonId");

                    b.HasIndex("RelativesPersonId");

                    b.ToTable("PersonPerson");
                });

            modelBuilder.Entity("HealthCareApplication.Domains.Models.HealthMetric", b =>
                {
                    b.HasOne("HealthCareApplication.Domains.Models.Person", "Person")
                        .WithMany("HealthMetrics")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("PersonPerson", b =>
                {
                    b.HasOne("HealthCareApplication.Domains.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HealthCareApplication.Domains.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("RelativesPersonId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HealthCareApplication.Domains.Models.Person", b =>
                {
                    b.Navigation("HealthMetrics");
                });
#pragma warning restore 612, 618
        }
    }
}
