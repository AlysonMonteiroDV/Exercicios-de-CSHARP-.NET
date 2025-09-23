using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //split cortar uma string em elementos por algum divisor
            Console.WriteLine("Frutas");
            string cestaFrutas = Console.ReadLine();
            Console.WriteLine("Compras");
            string listaDeCompras = Console.ReadLine();

            string f1 = CortadorDeFrutas(cestaFrutas,0);
            string m1 = DeixarLetraMaiusculaFrase(cestaFrutas);
            string m2 = DeixarLetraMaiusculaCompra(listaDeCompras);
            string lc = AlinharCompras(listaDeCompras, 0);          
            Console.WriteLine($"Fruta um:{f1}");
            Console.WriteLine($"compra um: {lc}");
            Console.WriteLine($"MAIUSCULA FRUTAS {m1}");
            Console.WriteLine($"MAIUSCULA COMPRAS {m2}");
            
        }
       

        static string CortadorDeFrutas(string cestaFrutas,int fruta)
        {
            string[] frutas = cestaFrutas.Split(' ');

            return frutas[fruta];
        }
        static string DeixarLetraMaiusculaFrase(string cesta)
        {
            string frase = cesta.ToUpper();
            

            return frase;
        }

        static string DeixarLetraMaiusculaCompra(string compras)
        {
            string compra = compras.ToUpper();

            return compra;
        }

        static string AlinharCompras(string compras, int cont)
        {
            string[] Listacompras = compras.Split(", ");
            return Listacompras[cont];    

        }
        

        }

    }
