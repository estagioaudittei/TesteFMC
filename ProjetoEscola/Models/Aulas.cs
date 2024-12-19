public class Aula
{
    public int Id { get; set; } 
    public string Nome {get;set;} = string.Empty;
    public int CursoId {get;set;}
    public Curso? Curso { get; set;}
    public int ProfessorId {get; set;}
    public Professor? Professor { get; set; }
}