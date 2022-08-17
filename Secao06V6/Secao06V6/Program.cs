using System;

namespace Secao06V6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[]
            {
                "Maria", "Alex", "Bob"
            };

            /*for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }*/

            foreach (string objeto in vetor)
            {
                Console.WriteLine(objeto);
            }
        }
    }
}