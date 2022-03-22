namespace project_strongfitgym.Models
{
    public class Treino
    {
        public int TreinoID { get; set; }
        public int AlunoID { get; set; }
        public DateTime Data { get; set; }
        public DateTime Hora { get; set; }
        public Aluno Aluno { get; set; }
        public ICollection<Exercicio> Exercicios { get; set; }   

    }
}
