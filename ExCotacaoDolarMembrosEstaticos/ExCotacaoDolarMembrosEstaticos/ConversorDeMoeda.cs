using System;
using System.Globalization;

namespace ExCotacaoDolarMembrosEstaticos
{
    internal class ConversorDeMoeda
    {
        public static double CotacaoDolar;
        public static double dolares;
        

        public static double ConverterDolarParaReal(double dolares)
        {
            double taxaIOF = 0.06;
            double valorEmReais = dolares * CotacaoDolar;

            return  valorEmReais + (valorEmReais * taxaIOF);
        }
    }
}
