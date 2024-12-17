// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//CRUD
using var bd = new FuncionarioContext();


//create
bd.Add(new Funcionario{ id = 1, nome = "NomeTeste",idFuncao = 1 }); 
bd.SaveChanges();

//read
var Funcionario = bd.Funcionarios
.OrderBy( x => x.nome)
.FirstOrDefault();