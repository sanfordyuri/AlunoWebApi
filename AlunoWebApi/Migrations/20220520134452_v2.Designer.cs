﻿// <auto-generated />
using System;
using AlunoWebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlunoWebApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220520134452_v2")]
    partial class v2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("AlunoWebApi.Model.Aluno", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("CPF")
                        .HasColumnType("text");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("datetime");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<byte[]>("idEndereco")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.HasKey("Id");

                    b.HasIndex("idEndereco")
                        .IsUnique();

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("AlunoWebApi.Model.Endereco", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("Bairro")
                        .HasColumnType("text");

                    b.Property<string>("CEP")
                        .HasColumnType("text");

                    b.Property<string>("Logradouro")
                        .HasColumnType("text");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("AlunoWebApi.Model.Aluno", b =>
                {
                    b.HasOne("AlunoWebApi.Model.Endereco", "Endereco")
                        .WithOne("Aluno")
                        .HasForeignKey("AlunoWebApi.Model.Aluno", "idEndereco")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("AlunoWebApi.Model.Endereco", b =>
                {
                    b.Navigation("Aluno");
                });
#pragma warning restore 612, 618
        }
    }
}
