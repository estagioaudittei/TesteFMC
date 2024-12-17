namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string UltimoNome { get; set; }
        public string PrimeiroNome { get; set; }
        public DateOnly DataInscricao { get; set; }

        public ICollection<Enrollment> Inscricoes { get; set; } //ICollections representa uma colecao (hashmap?) de objetos da classe 
        // Enrollment, representando uma relacao de navegacao (?) entre duas entidades
        // permitir que o EF Core carregue os objetos relacionados
        // gerenciar os elementos da colecao

    }
}