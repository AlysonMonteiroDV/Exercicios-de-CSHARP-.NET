using System;
using System.Globalization;
using ExCotacaoDolarMembrosEstaticos;

namespace ExCotacaoDolarMembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("COMPRA DE DOLAR:");
            Console.Write("Qual a cotação do dólar? ");
            ConversorDeMoeda.CotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares você vai comprar? ");
            ConversorDeMoeda.dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor a ser pago em reais = " 
                       + ConversorDeMoeda.ConverterDolarParaReal(ConversorDeMoeda.dolares).ToString("F2"));

        }
    }
}
