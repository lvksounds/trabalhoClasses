using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoClasses.Models
{
    public class Aluno
    {
        public Aluno() { }
        public Aluno(int matricula, string name, Curso curso)
        {
            AlunoMatricula = matricula;
            NomeAluno = name;
            CursoAluno = curso;
        }
        public int AlunoMatricula { get; set; }
        public string NomeAluno { get; set; }
        public Curso CursoAluno { get; set; }
    }
}
