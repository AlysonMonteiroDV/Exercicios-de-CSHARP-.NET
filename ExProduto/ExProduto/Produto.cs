using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExProduto
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int QuantidadeProduto;


        //Metodo para calcular o valor total em estoque
        public double ValorTotalEmEstoque()
        {
            return Preco * QuantidadeProduto;
        }

        //Metodo para adicionar produtos no estoque
        // Void pois não retorna nada
        //recebe como parametro a quantidade de produtos a ser adicionada
        //parametos sempre são com letra minuscula
        public void AdicionarProdutos(int quantidade)
        {
            QuantidadeProduto += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            QuantidadeProduto -= quantidade;
        }

        //ToString sobrescrito para apresentar os dados do produto
        public override string ToString()
        {
            //definição da logica de transformar os dados em string
            return Nome
                + ", R$"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + QuantidadeProduto
                + " unidades, Total: R$"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
