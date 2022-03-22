using Microsoft.EntityFrameworkCore;

namespace project_strongfitgym.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            Context context = app.ApplicationServices.GetRequiredService<Context>();

            DateTime date = DateTime.Now;

            context.Database.Migrate();

            if (!context.Personais.Any())
            {
                context.Personais.AddRange(
                    new Personal {
                        PersonalName = "Jorge", Especialidade = "Basquete" 
                    });

                context.Exercicios.AddRange(
                    new Exercicio {
                        Categoria = "Perna", Descricao = "desc exercicio", ExercicioName = "Abdutor" 
                    });

                context.Treinos.AddRange(
                    new Treino {
                        AlunoID = 1, Data = date, Hora = date 
                    });

                context.Alunos.AddRange(
                    new Aluno {
                        AlunoName = "Marcos", DataNascimento = date, Email = "email", Instagram = "@marcos", PersonalID = 1, Telefone = "35912", Observacoes = "cansado" 
                    });

                context.SaveChanges();
            }
        }
    }
}
