using System;
using System.Globalization;
using ExUmClasseMetodo;

namespace ExUmClasseMetodo
{
    public class Program
    {
        static void Main(string[] args)
        {
         Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do Retângulo ");
            Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("AREA: " + r.Area(r.Largura, r.Altura).ToString("F2"));
            Console.WriteLine("Perimetro: " + r.Perimetro(r.Largura,r.Altura).ToString("F2"));
            Console.WriteLine("Diagonal: " + r.Diagonal(r.Largura,r.Altura).ToString("F2"));

        }
    }



}
