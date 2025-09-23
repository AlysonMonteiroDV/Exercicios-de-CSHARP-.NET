using System;
using System.Globalization;
using ExProduto;
namespace ExProduto
{
    class Program {
        static void Main(string[] args)
        {
            //instanciação da classe Produto, objeto composto por 3 atributos
            Produto p = new Produto(); 

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine(); //atribuição do valor no atributo Nome da classe Produto
            Console.Write("Preço: ");
            //atribuição do valor no atributo Preco da classe Produto
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            //atribuição do valor no atributo Quantidade da classe Produto
            p.QuantidadeProduto = int.Parse(Console.ReadLine());

            //Dentro de writeLine, ele implicitamente chama o método ToString
            //sobrescrito na classe Produto, sem precisar chamar explicitamente
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado: ");
            // Leitura da quantidade de produtos a ser adicionada no estoque
            //Conversão de string para int
            int qte = int.Parse(Console.ReadLine());
            //chamada do método AdicionarProdutos receber a quantidade a ser adicionada
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);
            Console.Write("Digite o números de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);


        }
    
    }
}
                                                                                         