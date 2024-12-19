public class Instituicao
{
    public int InstituicaoId { get; set; }
    public string nomeInstituicao {get;set;} = string.Empty;
    public Professor Professor { get; set;} = new Professor();
}