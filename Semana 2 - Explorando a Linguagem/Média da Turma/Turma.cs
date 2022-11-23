using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Média_da_Turma
{
    public class Turma
    {
        public static double MediaDaTurma(List<Aluno> alunos)
        {
            int totalDeAlunos = alunos.Count;
            double somaDasNotas = 0;

            foreach(Aluno aluno in alunos)
            {
                somaDasNotas += aluno.Nota;
            }

            return somaDasNotas/ totalDeAlunos;
        }


    }
}
