﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartHint.Infrastucture;

#nullable disable

namespace SmartHint.Infrastucture.Migrations
{
    [DbContext(typeof(SmartHintDbContext))]
    [Migration("20240115020804_Primeira")]
    partial class Primeira
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SmartHint.Core.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Bloqueado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("InscricaoEstadual")
                        .HasColumnType("longtext");

                    b.Property<bool>("Isento")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("NomeRazaoSocial")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TipoPessoa")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });
#pragma warning restore 612, 618
        }
    }
}
