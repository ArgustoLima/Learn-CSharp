using System;

namespace Secao04V4Exercicio
{
    internal class ConversorDeMoedas
    {
        public static double Iof = 6.0;

        public static double DolarParaReal(double dollar, double comprar)
        {
            double total = comprar * dollar;
            return total + total * Iof / 100.0;
        }
    }
}
