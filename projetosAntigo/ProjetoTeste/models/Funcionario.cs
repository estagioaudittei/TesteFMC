using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using Npgsql.EntityFrameworkCore.PostgreSQL.ValueGeneration;
using Npgsql.EntityFrameworkCore.PostgreSQL.ValueGeneration.Internal;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Models.Funcionario{
public class FuncionarioContext : DbContext
{

    public DbSet<Funcao> Funcoes { get; set; }
    // DbSet > declarar no banco de dados
    // <Funcao> nosso object mapping, Funcao será um objeto com oque tera no banco de dados
    // Funcoes é nossa referencia na tabela ( nome da tabela que será salvo na tabela ) 
    public DbSet<Funcionario> funcionarios_table { get; set; }

    public DbSet<CampoAleatorio> RandomCampTest {get;set;}

    


    

    public string CaminhoBancoDeDados = "Host=localhost;Port=5432;Database=projetoteste;Username=alexandre2;Password=123;";

    // The following configures EF to create a Npgsql database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(CaminhoBancoDeDados)
        ;//.UseSnakeCaseNamingConvention(); // precisa adicionar EFCore.NamingConventions para adicionar isso porém já foi rodado o banco 1 vez, então isso causa erros depois de ser modificado 1 vez
        options.ConfigureWarnings(avisos => avisos.Ignore(RelationalEventId.PendingModelChangesWarning)) ;   
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)  
        {

            modelBuilder.Entity<Funcionario>()
            .HasIndex(prop => prop.id)
            .IncludeProperties(prop=> prop.nome);
        
            modelBuilder.Entity<Funcionario>()
            .Property(propriedade => propriedade.id)
            .HasColumnName("mudando_coluna_idfuncionario")
            .HasColumnType("bigint")
            .UseIdentityByDefaultColumn();

            modelBuilder.Entity<Funcionario>().Property(propriedade => propriedade.horarioRegistro)
            .HasColumnName("horario_cadastro_registro")
            .HasColumnType("timestamp")
            .HasDefaultValueSql("now()");

            modelBuilder.Entity<Funcionario>().Property(propriedade => propriedade.nome)
            .HasColumnName("nome_codificado_kkk")
            .HasColumnType("varchar")
            .IsRequired(false)
            .HasDefaultValueSql("gen_random_uuid()"); // -> funcao interna do postgresql?

            
            modelBuilder.Entity<Funcionario>()
            .HasOne(f => f.Funcao)
            .WithMany( f => f.Funcionarios)
            .HasForeignKey( f => f.idFuncao);


           

            modelBuilder.Entity<Funcao>().Property(propriedade => propriedade.FuncaoID)
            .HasColumnName("renomeando_coluna_id_funcao")
            .HasColumnType("integer");
        
        }
        
        
        
        
        // .HasAlternateKey(f => f.idFuncao); alternatekey significa chave estrangeira como se nao pudesse haver repetidas
        
        

    }
    

public class CampoAleatorio
{   
    
    public int ID { get; set; }
    public string campoTeste {get;set;}
    public string? campoTeste2 {get;set;}

}

public class Funcao
{
    public int FuncaoID {get;set;}

    public string nomeFuncao {get;set;}

    public List<string> turnos {get;set;}

    public ICollection<Funcionario> Funcionarios {get;set;}

    public Funcao()
    {

        FuncaoID = 0;
        nomeFuncao = "";
        turnos = new List<string>();

    }
    public Funcao(int Id, string nomeFuncao, List<string> turnos)
    {   
        FuncaoID=Id;
        nomeFuncao = nomeFuncao;
        turnos = turnos;
    }
}

public class Funcionario
{
    public int id {get;set;}
    public string nome {get;set;}
    public int idFuncao {get;set;}
    public Funcao Funcao {get;set;}
    public int idade {get;set;}
    public DateTime? horarioRegistro {get;set;}

    public Funcionario()
    {
        id = 0;
        nome = "";
        idFuncao = 0;
        idade = 0;
    }

    public Funcionario(int Id, string nomeFuncionario, int idFuncao, int idade)
    {
        id = Id;
        nome = nomeFuncionario;
        idFuncao = idFuncao;
        idade = idade;
    }

}
}