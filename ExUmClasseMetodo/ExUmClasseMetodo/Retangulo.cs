using System;

namespace ExUmClasseMetodo
{
    internal class Retangulo
    {
        //atributos
        public double Largura;
        public double Altura;


        //métodos 

        public double Area(double largura, double altura)
        {
            return largura * altura;
        }

        public double Perimetro(double largura, double altura)
        {
            double p;

            p = 2 * (largura + altura);
            return p;
        }

        public double Diagonal(double largura,double altura)
        {
            return Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura,2));
        }
    }
}
