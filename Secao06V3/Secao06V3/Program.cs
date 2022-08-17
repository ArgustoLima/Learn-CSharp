using System;

namespace Secao06V3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());
                vect[i] = new Product { Nome = nome, Preco = preco };
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Preco;
            }

            double avg = sum / n;

            Console.WriteLine("Preço médio: " + avg);
            
        }
    }
}