using System;
using System.Globalization;

namespace Secao04V4Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dólar? ");
            double dollar = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Quantos dolares você vai comprar? ");
            double comprar = double.Parse(Console.ReadLine());

            double result = ConversorDeMoedas.DolarParaReal(dollar, comprar);

            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}