using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCourse.Common.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
            Console.WriteLine($"Aluno {aluno.Name} adicionado.");
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            return Alunos.Count;
        }

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
            Console.WriteLine($"Aluno {aluno.Name} removido.");
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do Curso de {Nome}:");
            Alunos.ForEach(aluno =>
            {
                Console.WriteLine($"- {aluno.FullName}");
            });
        }
    }
}