using System;
using System.Globalization;

namespace ExFixacaoContaBancaria
{
    internal class ContaBancaria
    {

        //Atributos publicos com get e set
        public int NumConta { get; private set; }
        public string NomeTitular { get; set; }
        public double SaldoConta { get; private set; }

        //Construtores

        public ContaBancaria()
        {
        }
        public ContaBancaria(int numConta, string nomeTitular, double saldoConta)
        {
            NumConta = numConta;
            NomeTitular = nomeTitular;
            SaldoConta = saldoConta;
        }


        public ContaBancaria(int numConta, string nomeTitular)
        {
            NumConta = numConta;
            NomeTitular = nomeTitular;
            SaldoConta = 0.0;
        }

        //Metodos
        public double DepositoInicial(double deposito)
        {
            return SaldoConta += deposito;
        }

        public double Deposito(double deposito)
        {
            return SaldoConta += deposito;
        }

        public double Saque(double saque)
        {
            return SaldoConta -= saque + 5;
        }

        public void AdicionarNumConta(int conta)
        {
            NumConta = conta;
        }


        public override string ToString()
        {
            return "Conta: "
                + NumConta
                + ", Titular: "
                + NomeTitular
                + ", Saldo: $ "
                + SaldoConta.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
