namespace project_strongfitgym.Models
{
    public class Aluno
    {
        public int AlunoID { get; set; }
        public string AlunoName { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Instagram { get; set; }
        public string Telefone { get; set; }
        public int PersonalID { get; set; }
        public string Observacoes { get; set; }
        public Personal Personal { get; set; }
        public ICollection<Treino> Treinos { get; set; }
    }
}
