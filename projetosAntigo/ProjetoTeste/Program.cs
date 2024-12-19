// See https://aka.ms/new-console-template for more information
using System.Data.Common;
using Models.Funcionario;

Console.WriteLine("Hello, World!");
Console.WriteLine("Começando a compilar");



//CRUD
using var bd = new FuncionarioContext();


//create
Console.WriteLine("Adicionando um novo Funcionario");
bd.Add(new Funcionario{ id = 1, nome = "NomeTeste",idFuncao = 1 }); 
bd.SaveChanges();
Thread.Sleep(20000);
//read
var Funcionario = bd.funcionarios_table // aqui pega o objeto
.OrderBy( x => x.nome)
.FirstOrDefault();


//update
Console.WriteLine("Atualizando um novo Funcionario");
Funcionario.nome = "mudou para Nome2";
bd.SaveChanges();
Thread.Sleep(20000);


Console.WriteLine("Removendo um novo Funcionario");
bd.Remove(Funcionario);
bd.SaveChanges();
Thread.Sleep(20000);
