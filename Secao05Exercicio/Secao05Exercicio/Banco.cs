using System;
using System.Globalization;

namespace Secao05Exercicio
{
    internal class Banco
    {
        public int NumeroConta { get; set; }
        public string Nome { get; set; }
        public char TemSaldo { get; set; }  
        public double Saldo { get; set; }   

        public Banco(int numeroConta, string nome, double saldo)
        {
            NumeroConta = numeroConta;
            Nome = nome;
            Saldo = saldo;
        }

        public void Deposito(double saldo)
        {
            Saldo += saldo;
        }

        public void Saque(double saldo)
        {
            Saldo -= saldo;
            Saldo -= 5;
        }

        public override string ToString()
        {
            return "Conta " + NumeroConta + ", Titular: " + Nome + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture); 
        }

    }
}
