using System;

namespace Secao06V3Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quatos vão ser alugados ");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n || i == 9; i++)
            {
                Console.WriteLine();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("-=-=-=-=-=-=-=-=-");
                vect[i] = new Product { Nome = nome, Email = email, Quarto = quarto };
            }

            Console.WriteLine("Quartos: ");
            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine();
                    Console.Write("Nome: ");
                    Console.Write(vect[i].Nome);
                    Console.WriteLine();
                    Console.Write("email: ");
                    Console.Write(vect[i].Email);
                    Console.WriteLine();
                    Console.Write("N° Quarto: ");
                    Console.Write(vect[i].Quarto);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("-=-=-=-=-=-=-=-=-");
                }
            }
        }
    }
}