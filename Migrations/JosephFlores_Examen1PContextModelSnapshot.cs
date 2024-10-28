﻿// <auto-generated />
using System;
using JosephFlores_Examen1P.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JosephFlores_Examen1P.Migrations
{
    [DbContext(typeof(JosephFlores_Examen1PContext))]
    partial class JosephFlores_Examen1PContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JosephFlores_Examen1P.Models.JF_Proteina", b =>
                {
                    b.Property<int>("ProteinaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProteinaId"));

                    b.Property<DateTime?>("Date")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("WheyProtein")
                        .HasColumnType("bit");

                    b.HasKey("ProteinaId");

                    b.ToTable("JF_Proteina");
                });
#pragma warning restore 612, 618
        }
    }
}