﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Turrist_agent.Data;

namespace Turrist_agent.Migrations
{
    [DbContext(typeof(Turrist_agentContext))]
    [Migration("20201024113952_Ini")]
    partial class Ini
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Turrist_agent.Moduls.Dolzhnosti", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name_dolzhnosti")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Obyazannosti")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Oklad")
                        .HasColumnType("int");

                    b.Property<long?>("SotrudnikiID")
                        .HasColumnType("bigint");

                    b.Property<string>("Trebovaniya")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("SotrudnikiID");

                    b.ToTable("Dolzhnosti");
                });

            modelBuilder.Entity("Turrist_agent.Moduls.Sotrudniki", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FIO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Kod_dolzhnosti")
                        .HasColumnType("bigint");

                    b.Property<int>("Pass_dannie")
                        .HasColumnType("int");

                    b.Property<string>("Pol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefon")
                        .HasColumnType("int");

                    b.Property<int>("Vozrast")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Sotrudniki");
                });

            modelBuilder.Entity("Turrist_agent.Moduls.Dolzhnosti", b =>
                {
                    b.HasOne("Turrist_agent.Moduls.Sotrudniki", null)
                        .WithMany("Dolzhnosti")
                        .HasForeignKey("SotrudnikiID");
                });
#pragma warning restore 612, 618
        }
    }
}
