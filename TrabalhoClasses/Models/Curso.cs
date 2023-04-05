using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoClasses.Models
{
    public class Curso
    {
        
        public Curso() { }

        public Curso(int cursoId, string nomeCurso)
        {
            CursoID = cursoId;
            CursoName = nomeCurso;
        }

        public int CursoID { get; set; }

        public string CursoName { get; set;}

        public static int TotalAlunos { get; set; }

        public List<Aluno> Alunos = new List<Aluno>();
        
        public void FazMatricula(Aluno aluno)
        {
            Alunos.Add(aluno);
            TotalAlunos += 1;
        }
    }
}
