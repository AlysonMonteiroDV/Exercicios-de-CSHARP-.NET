using System.Globalization;


namespace Course
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        // Construtores
        //Possui o mesmo nome da classe
        // ter mais de um construtor é chamado de sobrecarga de construtores
        public Produto()
        {

        }
        public Produto(string nome,double preco, int quantidade)
        {
            //Atributo =  parametro
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto(string nome, double preco)
        {
            //Atributo =  parametro
            //naturalmente a quantidade inicia com zero
            //por ser um int mas double também inicia com zero
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
            
        }
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
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}