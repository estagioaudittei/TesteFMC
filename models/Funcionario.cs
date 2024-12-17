using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

public class FuncionarioContext : DbContext
{

    public DbSet<Funcao> Funcoes { get; set; }
    // DbSet > declarar no banco de dados
    // <Funcao> nosso object mapping, Funcao será um objeto com oque tera no banco de dados
    // Funcoes é nossa referencia na tabela (possivelmente até mesmo o nome) 
    public DbSet<Funcionario> Funcionarios { get; set; }

}

public class Funcao
{
    public int FuncaoID {get;set;}

    public string nomeFuncao {get;set;}

    public List<string> turnos {get;set;}

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

    public Funcionario()
    {
        id = 0;
        nome = "";
        idFuncao = 0;
    }

    public Funcionario(int Id, string nomeFuncionario, int idFuncao)
    {
        id = Id;
        nome = nomeFuncionario;
        idFuncao = idFuncao;
    }

}