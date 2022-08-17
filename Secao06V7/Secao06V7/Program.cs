using System;
using System.Collections.Generic;

namespace Secao06V7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* List<string> list = new List<string>();

            List<string> list2 = new List<string>
            {
                "Maria", "Alex", "João"
            }; */

            List<string> lista = new List<string>();
            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("Bob");
            lista.Add("Ana");

            foreach (string objeto in lista)
            {
                Console.WriteLine(objeto);
            }

            Console.WriteLine("-=-=-=-=-=-=-=-");
            lista.Insert(1, "Augusto");
            lista.Insert(5, "Marco");

            foreach (string objeto in lista)
            {
                Console.WriteLine(objeto);
            }

            Console.WriteLine("-=-=-=-=-=-=-=-");

            Console.WriteLine("Lis count: " + lista.Count);

            string s1 = lista.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro com a letra A: " + s1);

            string s2 = lista.FindLast(x => x[0] == 'A');
            Console.WriteLine("Último com a letra A: " + s2);

            int pos1 = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position A: " + (pos1  + 1));

            int pos2 = lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last postion A: " + (pos2 + 1));

            Console.WriteLine("-=-=-=-=-=-=-=-");
            List<string> lista2 = lista.FindAll(x => x.Length == 5);
            foreach (string obj in lista2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-=-=-=-=-=-=-=-");
            lista.Remove("Alex");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }

            
            Console.WriteLine("-=-=-=-=-=-=-=-");
            lista.RemoveAll(x => x[0] == 'M');
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-=-=-=-=-=-=-=-");
            lista.RemoveAt(1);
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }

            /* Console.WriteLine("-=-=-=-=-=-=-=-");
            lista.RemoveRange(2, 2);
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            } */

        }

        /* static bool Test(string s)
        {
            return s[0] == 'A';
        } */
    }
}