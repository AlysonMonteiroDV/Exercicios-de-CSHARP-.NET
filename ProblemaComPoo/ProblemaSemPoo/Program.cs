using NameSpaceTriangulo;
using System;
using System.Globalization;



namespace ProblemasSemPoo
{
    class Program
    {
        static void Main(string[] args) {
            //instanciando a classe triangulo
            Triangulo x, y;
            Quadrado q;

            q = new Quadrado();
            x = new Triangulo();
            y = new Triangulo();



            Console.WriteLine("Entre com as médidas do triângulo X: ");

            //Solicitando a entrada da informação e já tranformando ela de string
            // para double
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as médidas do triângulo Y: ");

            //Solicitando a entrada da informação e já tranformando ela de string
            // para double
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Chamada do calculo da area do triangulo

            Console.WriteLine
                ("Área de X: " +
                CalculoAreaTriangulo(x.A,x.B,x.C).ToString("F4", CultureInfo.InvariantCulture
                ));
            Console.WriteLine
                ("Área de Y: " +
                CalculoAreaTriangulo(y.A,y.B,y.C).ToString("F4"), CultureInfo.InvariantCulture
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
