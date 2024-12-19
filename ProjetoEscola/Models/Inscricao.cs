public class Inscricao
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public Estudante Estudante { get; set; } = new Estudante();
    public Curso Curso {get;set;} = new Curso();
}