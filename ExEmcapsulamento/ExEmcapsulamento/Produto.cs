using System.Globalization;
namespace Course
{
    class Produto
    {
        // Padrão de nomenclatura _nomePropriedade para atributos privados
        private string _nome;
        private double _preco;
        private int _quantidade;


        //metodos get e set
        //forma manual

        //get e set do atributo nome
        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if(nome != null && nome.Length > 1) { 
            _nome = nome;
            }
        }
        //get do atributo preco

        public double GetPreco()
        {
            return _preco;
        }

        //get do atributo quantidade

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public Produto()
        {

        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
