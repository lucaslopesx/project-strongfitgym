namespace project_strongfitgym.Models
{
    public class Personal
    {
        public int PersonalID { get; set; }
        public string PersonalName { get; set; }
        public string Especialidade { get; set; }
        public ICollection<Aluno> Alunos { get; set; }
    }
}
