public class Materia
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public ICollection<Curso>? Curso { get; set; }
    public int CursoId { get; set; }
    public Professor? Professor {get; set; }
    public int ProfessorId {get;set;}

}