using TrabalhoClasses.Models;

Curso curso = new Curso(10, "S.I");

Aluno aluno1 = new Aluno(202110832, "Lucas de Freitas", curso);
Aluno aluno2 = new Aluno(202110546, "Jader Cardoso", curso);
Aluno aluno3 = new Aluno(202110201, "Sarah Carla", curso);

List<Aluno> ListaDeALunos = new List<Aluno>() { aluno1, aluno2, aluno3};

foreach(Aluno aluno in ListaDeALunos)
{
    curso.FazMatricula(aluno);
    Console.WriteLine("Nome do aluno: {0}", aluno.NomeAluno);
    Console.WriteLine("Matricula do aluno: {0}", aluno.AlunoMatricula);
    Console.WriteLine("Curso: {0}", aluno.CursoAluno.CursoName);
    Console.WriteLine();
}

Console.WriteLine("Lista de Alunos: {0}", curso.Alunos.Count);
Console.WriteLine("Total de alunos: {0}", Curso.TotalAlunos);
  


