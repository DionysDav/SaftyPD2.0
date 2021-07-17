﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Practica1.DataAccessLayer;

namespace Practica1.Migrations.ApplicationDbETKC
{
    [DbContext(typeof(ApplicationDbETKCContext))]
    [Migration("20210708114341_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Practica1.Domains.Applicant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("EventId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsConsentedForProcessingOfPD")
                        .HasColumnType("boolean");

                    b.Property<int>("PersonCountInGroup")
                        .HasColumnType("integer");

                    b.Property<DateTime>("PlanVisitDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("PlanVisitTime")
                        .HasColumnType("text");

                    b.Property<DateTime>("TimeReques")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UserIdent")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Applicants");
                });
#pragma warning restore 612, 618
        }
    }
}