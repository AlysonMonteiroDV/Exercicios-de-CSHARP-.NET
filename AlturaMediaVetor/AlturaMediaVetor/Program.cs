using System;
using System.Globalization;

namespace AlturaMediaVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // instanciando um vetor na memoria heap com N posicoes.
            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;

            for(int i = 0; i < n; i++)
            {
                sum = sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2"),CultureInfo.InvariantCulture);

        }
    }
}