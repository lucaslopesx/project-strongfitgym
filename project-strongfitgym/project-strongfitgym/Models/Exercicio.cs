﻿namespace project_strongfitgym.Models
{
    public class Exercicio
    {
        public int ExercicioID { get; set; }
        public string ExercicioName { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public ICollection<Treino> Treinos { get; set; }
    }
}
