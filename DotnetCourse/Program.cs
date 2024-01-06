using DotnetCourse.Common.Models;

Pessoa p1 = new(
  name: "Daniel", 
  surname: "Maicá", 
  age: 24
);

Pessoa p2 = new(
  name: "Taynara", 
  surname: "Anacleto", 
  age: 22
);

Curso cursoDeIngles = new()
{
  Nome = "Inglês",
  Alunos = new List<Pessoa>()
};
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
cursoDeIngles.RemoverAluno(p1);
cursoDeIngles.ListarAlunos();