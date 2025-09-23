using System;
using System.Globalization;


namespace ExdoisFuncionarioClassMetodo
{
    class Program 
    {
        static void Main(string[] arg)
        {
            funcionario f = new funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: " + f);
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            int porcentagem = int.Parse(Console.ReadLine());
            f.AumentarSalario(porcentagem);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + f);

        }
    }

}
