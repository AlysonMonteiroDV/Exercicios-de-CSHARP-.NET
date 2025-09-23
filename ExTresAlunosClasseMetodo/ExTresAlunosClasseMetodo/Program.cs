using System;
using System.Globalization;
using ExtresAlunosClasseMetodo;
using ExTresAlunosClasseMetodo;

namespace ExtresAlunosClasseMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            Console.Write("Nome do Aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno");
            a.Nota1 = int.Parse(Console.ReadLine());
            a.Nota2 = int.Parse(Console.ReadLine());
            a.Nota3 = int.Parse(Console.ReadLine());
            int notafinal = a.NotaFinal(a.Nota1, a.Nota2, a.Nota3);
            Console.WriteLine("Nota Final: " );
            Console.WriteLine(notafinal);
            if(notafinal >= 60)
            {
                Console.WriteLine(a.Aprovado(notafinal));
            }
            else
            {
                Console.WriteLine(a.Aprovado(notafinal));
                Console.WriteLine("FALTARAM: " + a.NotaRestante(notafinal).ToString("F2"),CultureInfo.InvariantCulture + " PONTOS");
            }

                
        }
    }
}
