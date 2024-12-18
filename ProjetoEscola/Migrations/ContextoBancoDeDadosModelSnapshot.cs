﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Escola.Migrations
{
    [DbContext(typeof(ContextoBancoDeDados))]
    partial class ContextoBancoDeDadosModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Aula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CursoId")
                        .HasColumnType("integer")
                        .HasColumnName("id_curso");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR")
                        .HasColumnName("nome_aula");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Aulas");
                });

            modelBuilder.Entity("Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("MateriaId")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MateriaId");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("Estudante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Estudantes");
                });

            modelBuilder.Entity("Inscricao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CursoId")
                        .HasColumnType("integer");

                    b.Property<int>("EstudanteId")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("EstudanteId");

                    b.ToTable("Inscricoes");
                });

            modelBuilder.Entity("Instituicao", b =>
                {
                    b.Property<int>("InstituicaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("InstituicaoId"));

                    b.Property<string>("nomeInstituicao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("InstituicaoId");

                    b.ToTable("Instituicoes");
                });

            modelBuilder.Entity("Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CursoId")
                        .HasColumnType("integer")
                        .HasColumnName("id_curso_qtsHein");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("integer")
                        .HasColumnName("id_do_professor");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("InstituicaoId")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("InstituicaoId")
                        .IsUnique();

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("Aula", b =>
                {
                    b.HasOne("Curso", "Curso")
                        .WithMany("Aulas")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Professor", "Professor")
                        .WithMany("Aulas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("Curso", b =>
                {
                    b.HasOne("Materia", null)
                        .WithMany("Curso")
                        .HasForeignKey("MateriaId");
                });

            modelBuilder.Entity("Inscricao", b =>
                {
                    b.HasOne("Curso", "Curso")
                        .WithMany("Inscricao")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Estudante", "Estudante")
                        .WithMany("Inscricao")
                        .HasForeignKey("EstudanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Estudante");
                });

            modelBuilder.Entity("Materia", b =>
                {
                    b.HasOne("Professor", "Professor")
                        .WithMany("Materias")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("Professor", b =>
                {
                    b.HasOne("Instituicao", "Instituicao")
                        .WithOne("Professor")
                        .HasForeignKey("Professor", "InstituicaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instituicao");
                });

            modelBuilder.Entity("Curso", b =>
                {
                    b.Navigation("Aulas");

                    b.Navigation("Inscricao");
                });

            modelBuilder.Entity("Estudante", b =>
                {
                    b.Navigation("Inscricao");
                });

            modelBuilder.Entity("Instituicao", b =>
                {
                    b.Navigation("Professor")
                        .IsRequired();
                });

            modelBuilder.Entity("Materia", b =>
                {
                    b.Navigation("Curso");
                });

            modelBuilder.Entity("Professor", b =>
                {
                    b.Navigation("Aulas");

                    b.Navigation("Materias");
                });
#pragma warning restore 612, 618
        }
    }
}
