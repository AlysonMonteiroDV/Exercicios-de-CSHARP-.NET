using System;
using System.Globalization;


namespace ProblemasSemPoo
{
    class Program
    {
        static void Main(string[] args) {

            //declarando as variaveis
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as médidas do triângulo X: ");

            //Solicitando a entrada da informação e já tranformando ela de string
            // para double
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as médidas do triângulo Y: ");

            //Solicitando a entrada da informação e já tranformando ela de string
            // para double
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Chamada do calculo da area do triangulo

            Console.WriteLine
                ("Área de X: " +
                CalculoAreaTriangulo(xA,xB,xC).ToString("F4", CultureInfo.InvariantCulture
                ));
            Console.WriteLine
                ("Área de Y: " +
                CalculoAreaTriangulo(yA,yB,yC).ToString("F4"), CultureInfo.InvariantCulture
                );

        }

        static double CalculoAreaTriangulo(double a, double b, double c)
        {
            double p = (a + b + c) / 2.0;
            double areaTriangulo = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return areaTriangulo;
        }
    }
    }
