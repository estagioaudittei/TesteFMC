public class Curso
{
    public int? Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public ICollection<Inscricao>? Inscricao { get; set;}
    public ICollection<Aula>? Aulas { get; set;}
}