public class Professor 
{
    public int Id {get;set;}
    public string Nome {get;set;} = string.Empty;
    public int InstituicaoId {get;set;}
    public Instituicao? Instituicao {get;set;}
    public ICollection<Aula>? Aulas {get;set;}
    public ICollection<Materia>? Materias {get;set;}   
}