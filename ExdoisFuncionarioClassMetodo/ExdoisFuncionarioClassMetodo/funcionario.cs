using System;

namespace ExdoisFuncionarioClassMetodo
{
    class funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        public double SalarioLiquido(double salarioBruto, double imposto)
        {
            return salarioBruto - imposto;
        }

        public void AumentarSalario(double porcentacem)
        {
            SalarioBruto += SalarioBruto * porcentacem / 100;
        }


        public override string ToString()
        {
            return Nome + ", R$" + SalarioLiquido(SalarioBruto, Imposto).ToString("F2");
        }
    }
}
