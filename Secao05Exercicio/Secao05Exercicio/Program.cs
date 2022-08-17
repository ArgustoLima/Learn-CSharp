using System;
using System.Globalization;

namespace Secao05Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco conta = new Banco(999999, "Nome", 0.00);

            Console.Write("Entre o número da conta: ");
            int numTitular = int.Parse(Console.ReadLine());
            conta.NumeroConta = numTitular;

            Console.WriteLine();
            Console.Write("Entre com o titular da conta: ");
            string nomeTitular = Console.ReadLine();
            conta.Nome = nomeTitular;

            Console.WriteLine();
            Console.Write("Haverá depósito incial (s/n)? ");
            char temSaldo = char.Parse(Console.ReadLine());
            conta.TemSaldo = temSaldo;

            if (temSaldo == 's') {
                Console.WriteLine();
                Console.Write("Entre com o valor de depósito incial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Saldo = saldo;
            } else if (temSaldo == 'n') {
                conta.Saldo = 0.00;
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double depositoSaldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(depositoSaldo);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saqueSaldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saqueSaldo);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados (-5 reais por saque): ");
            Console.WriteLine(conta);

        }
    }
}