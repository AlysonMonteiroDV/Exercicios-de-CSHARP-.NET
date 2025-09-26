using System;
using System.Globalization;

namespace ExMembrosEstaticos
{
    class Program
    {
        //definição do valor de PI como membro estático.
        
        static void Main(string[] args)
        {
            //classe intanciada
            //Calculadora calc = new Calculadora(); 


            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI:" + Calculadora.Pi);
        }
        //só é possível chamar uma classe estatica dentro de outra classe estatica.
        //Metodo sem precisar ser instanciado,
        //precisa ser estatico para ser chamado dentro do main que é estatico.
        
    }

}
