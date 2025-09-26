using System;
using System.Globalization;

namespace ExMembrosEstaticos
{
    class Program
    {
        //definição do valor de PI como membro estático.
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI:" + Pi);
        }
        //só é possível chamar uma classe estatica dentro de outra classe estatica.
        //Metodo sem precisar ser instanciado,
        //precisa ser estatico para ser chamado dentro do main que é estatico.
        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
    }

}
