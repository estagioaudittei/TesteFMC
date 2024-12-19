﻿// <auto-generated />
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models.Funcionario;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ProjetoTeste.Migrations
{
    [DbContext(typeof(FuncionarioContext))]
    [Migration("20241218182253_update7")]
    partial class update7
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Models.Funcionario.CampoAleatorio", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("campoTeste")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("campoTeste2")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("RandomCampTest");
                });

            modelBuilder.Entity("Models.Funcionario.Funcao", b =>
                {
                    b.Property<int>("FuncaoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("renomeando_coluna_id_funcao");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("FuncaoID"));

                    b.Property<string>("nomeFuncao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.PrimitiveCollection<List<string>>("turnos")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.HasKey("FuncaoID");

                    b.ToTable("Funcoes");
                });

            modelBuilder.Entity("Models.Funcionario.Funcionario", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("mudando_coluna_idfuncionario");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("id"));

                    b.Property<int>("idFuncao")
                        .HasColumnType("integer");

                    b.Property<int>("idade")
                        .HasColumnType("integer");

                    b.Property<string>("nome")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar")
                        .HasColumnName("nome_codificado_kkk")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.HasKey("id");

                    b.ToTable("funcionarios_table");
                });
#pragma warning restore 612, 618
        }
    }
}
