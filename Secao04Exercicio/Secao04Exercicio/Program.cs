using System;

namespace exercicio
{
    class ExercicioClasses
    {
        static void Main(string[] args)
        {
            ExercicioFuncionario nome, salario;

            ExercicioFuncionario funcionario01 = new ExercicioFuncionario();
            ExercicioFuncionario funcionario02 = new ExercicioFuncionario();

            funcionario01.nome = "Augusto";
            funcionario01.salario = 1700.00;

            funcionario02.nome = "Maria";
            funcionario02.salario = 1200.00;

            Console.WriteLine($"Nome: {funcionario01.nome} Salário: {funcionario01.salario}");
            Console.WriteLine($"Nome: {funcionario02.nome} Salário: {funcionario02.salario}");

            double salarioMedio = (funcionario01.salario + funcionario02.salario) / 2;

            Console.WriteLine("Salário médio: " + salarioMedio);



        }
    }
}