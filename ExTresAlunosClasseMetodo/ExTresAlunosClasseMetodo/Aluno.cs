using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTresAlunosClasseMetodo
{
    class Aluno
    {
        public string Nome;
        public int Nota1, Nota2, Nota3;


        public int NotaFinal(int nota1, int nota2, int nota3)
        {
            return nota1 + nota2 + nota3;
        }

        public string Aprovado(int notafinal)
        {
            if (notafinal >= 60)
            {
                return "APROVADO";
            }
            else
            {
                return "REPROVADO";

            }
        }

        public double NotaRestante(int notafinal)
        {
            return 60 - notafinal;
        }
    }
}
