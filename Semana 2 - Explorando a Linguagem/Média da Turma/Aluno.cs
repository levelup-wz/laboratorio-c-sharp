using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Média_da_Turma
{
    public class Aluno
    {
        public double Nota { get; private set; }
        
        public void AdicionaNota(double nota)
        {
            Nota = nota;
        }
    }
}
