using System.Globalization;
using System.Runtime.CompilerServices;
namespace Course
{
    class Produto
    {
        //atributo privado
        private string _nome;

        //atributos autoimplementados (autoProperties)
        public double Preco { get; private set; } //autoProperty
        public int Quantidade { get; private set; }


        //Properties 
        //Value: palavra reservada que representa o valor que está sendo atribuído à propriedade
        //A palavra Value é 
        public String Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        //Construtores(Constructor)
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;


        }

        //Metodos da classe
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
