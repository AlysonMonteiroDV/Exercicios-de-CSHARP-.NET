using System;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;



namespace ExFixacaoContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("CONTA BANCARIA");

            Console.Write("Entre com o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string Titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string deposito = Console.ReadLine().ToLower();

            double ValorConta; //variavel para armazenar o valor da conta
            if (deposito == "s")
            {
                Console.Write("Entre com o valor do deposito: ");
                ValorConta = double.Parse(Console.ReadLine());
            }
            else
            {
                ValorConta = 0.0;
            }

            ContaBancaria conta = new ContaBancaria(numeroConta, Titular, ValorConta);

            MostrarConta(conta);
         
            Console.WriteLine();
            Console.Write("Entre com o valor para outro depósito: ");
            ValorConta = conta.Deposito(double.Parse(Console.ReadLine()));

            MostrarConta(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            ValorConta = conta.Saque(double.Parse(Console.ReadLine()));

            MostrarConta(conta);

        }

        static void MostrarConta(object conta )
        {
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
        }
    }
}
