using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
public class ContextoBancoDeDados : DbContext
{   
    public DbSet<Curso> Cursos { get;set;}
    public DbSet<Instituicao> Instituicoes { get;set;}
    public DbSet <Materia> Materias {get;set;}
    public DbSet <Aula> Aulas {get;set;}
    public DbSet <Professor> Professores {get;set;}
    public DbSet <Estudante> Estudantes {get;set;}
    public DbSet <Inscricao> Inscricoes {get;set;}   
    public string ConexaoBD = "Host=localhost;Port=5432;Username=alexandre2;Password=123;Database=projetoescola;";
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseNpgsql(ConexaoBD);
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Aula>()
        .HasKey(a => a.Id);

        builder.Entity<Aula>().Property(a => a.Nome)
        .HasColumnName("nome_aula")
        .HasColumnType("VARCHAR")
        ;

        builder.Entity<Aula>().Property(a => a.CursoId)
        .HasColumnName("id_curso");

        builder.Entity<Materia>().Property(a => a.CursoId)
        .HasColumnName("id_curso_qtsHein");

        builder.Entity<Materia>().Property(a => a.ProfessorId)
        .HasColumnName("id_do_professor");




    }

}