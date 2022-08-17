using System;
using System.Globalization;


namespace PrimeiroProjeto
{
    class Secao03
    {
        static void Main(string[] args)
        {

            // Tipos básicos de Dados

            bool completo = false;
            char genero = 'f';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Green";
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;
            int n7 = int.MinValue;
            long n8 = long.MaxValue;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(n7);
            Console.WriteLine(n8);

            // Saídas de Dados

            Console.WriteLine("Bom dia"); /* Faz a quebra de linha quando 
            quando termina a frase */

            Console.Write("Boa tarde ");
            Console.Write("Boa noite"); /*Ele continua na mesma linha
            quando termina a frase */

            char generoo = 'F';
            int idadee = 32;
            string nomee = "Maria";
            double saldoo = 10.35784;

            Console.WriteLine(generoo);
            Console.WriteLine(idadee);
            Console.WriteLine(nomee);
            Console.WriteLine("Saldo : " + saldoo); /* Ele vai imprimir o
            saldo completo */
            Console.WriteLine("Saldo delimitado: " + saldoo.ToString("f2"));
            /* Nesse ele vai imprimir o resultado delimitando duas casa
            por causa do ToStrinf F2 */
            Console.WriteLine("Saldo: " + saldoo.ToString("f2", CultureInfo.InvariantCulture));
            // Ele vai imprimir mas ao invés da "," ele vai usar o "."

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:f2} reais", nomee, idadee, saldoo);

            Console.WriteLine($"{nomee} tem {idadee} anos e tem saldo igual a {saldoo:f2} reais");

            Console.WriteLine(nomee + " tem " + idadee + " anos e tem saldo igual a " + saldoo.ToString("f2", CultureInfo.InvariantCulture) + " reais");

            // Exercícios de fixação

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char generooo = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("-=-=-=-=-=-=- Exercício -=-=-=-=-=-=-");
            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1}, cujo o preço é de ${preco1:f2}");
            Console.WriteLine($"{produto2}, cujo o preço é de ${preco2:f2}");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e genêro: {generooo}");
            Console.WriteLine($"Medida  com oito casas decimais: {medida:f8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:f3}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("f3", CultureInfo.InvariantCulture)}");
            Console.WriteLine("-=-=-=-=-=-=- Exercício -=-=-=-=-=-=-");

            // Operadores de Atribuição

            int a = 2;
            a += 10;
            Console.WriteLine(a);
            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);
            s += "DEF";
            Console.WriteLine(s);

            int z = 10;
            Console.WriteLine("z: " + z);
            z++;
            Console.WriteLine("z++: " + z);
            z = 10;
            z--;
            Console.WriteLine("z--: " + z);


            // Conveções implicitas e casting

            float x = 4.5f;
            double f = x;
            Console.WriteLine(f);   

            double a2;
            float b2;

            a2 = 5.1;
            // b2 = a2; --> dá erro porque ele não pode converte para float 
            b2 = (float)a2; /* assim você declara que deixa ele virar float mesmo
            que tenha perda de informação. */

            int c2;
            c2 = (int)a2; /* assim eu declaro como int e como se torna inteiro
            ele vair deixar de ser ponto flutuante e deixa de ter a "," */
            Console.WriteLine(c2);

            int a3 = 5;
            int b3 = 2;

            double resultado = a3 / b3;
            Console.WriteLine(resultado); /* como ele converte um inteiro para double
            ele não vai trasnforma em double que é com vírgula */

            resultado = (double)a3 / b3;
            Console.WriteLine(resultado); /* dessa forma eu declaro que estou transformando
            o int em double, logo vai dar 2,5 */

            int n1q = 3 + 4 * 2;
            int n2q = (3 + 4) * 2;
            int n3q = 17 % 3;
            double n4q = (double) 10 / 8;

            Console.WriteLine(n1q);
            Console.WriteLine(n2q);
            Console.WriteLine(n3q);
            Console.WriteLine(n4q);

            double aq = 1.0, bq = -3.0, cq = -4.0;
            // double deltaq = b * b - 4.0 * a * c;
            double delta = Math.Pow(bq, 2.0) - 4.0 * aq* cq;

            double x1q = (-bq + Math.Sqrt(delta)) / (2.0 * aq);
            double x2q = (-bq - Math.Sqrt(delta)) / (2.0 * aq);

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("A: "+ aq);
            Console.WriteLine("B: "+ bq);
            Console.WriteLine("C: "+ cq);
            Console.WriteLine("Delta: "+ delta);
            Console.WriteLine("Resultado da equação x1: " + x1q);
            Console.WriteLine("Resultado da equação x2: " + x2q);
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-");


            // Entradas de dados
            // ReadLine - serve como forma de input, onde o cliente escreve algo e a variável 
            // armazena com string, com isso dps pode pegar e imprimir com os dados da variiável

            /* string fraseq = Console.ReadLine();
            string xq = Console.ReadLine();
            string yq = Console.ReadLine();
            string zq = Console.ReadLine(); 

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(fraseq);
            Console.WriteLine(xq);
            Console.WriteLine(yq);
            Console.WriteLine(zq); 
            Console.WriteLine(zq);  

            string sq = Console.ReadLine();
            //string[] vetq = Console.ReadLine().Split(' ');
            string[] vetq = sq.Split(' ');
            string veta = vetq[0];
            string vetb = vetq[1];
            string vetc = vetq[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(vetq);
            Console.WriteLine(veta);
            Console.WriteLine(vetb);
            Console.WriteLine(vetc);

            int num1q = int.Parse(Console.ReadLine()); // por ser int ele vai converter o int para string, porém 
            // o programa ele quebra quando escreve um string!
            char chq = char.Parse(Console.ReadLine());
            double num2q = double.Parse(Console.ReadLine());

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(num1q);
            Console.WriteLine(chq);
            Console.WriteLine(num2q); 

            string[] vet = Console.ReadLine().Split(' ');
            string nomeq = vet[0]; 
            char sexoq = char.Parse(vet[1]); 
            int idadeq = int.Parse(vet[2]);
            double alturaq = double.Parse(vet[3]);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(nomeq);
            Console.WriteLine(sexoq);
            Console.WriteLine(idadeq);
            Console.WriteLine(alturaq); 


            // Exercícios de fixação

            Console.WriteLine("Entre com seu nome completo: ");
            string[] nomecompleto = Console.ReadLine().Split(' ');
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Respostas: ");
            string primeironome = nomecompleto[0];
            string segundonome = nomecompleto[1];
            Console.WriteLine("Nome: " + primeironome);
            Console.WriteLine("Sobrenome: " + segundonome);
            Console.WriteLine("Quartos: " + quartos);
            Console.WriteLine("Preço do produto: " + preco.ToString("f2",CultureInfo.InvariantCulture)); */

            // Operadores de comparação

            int aa = 10;
            bool cc1 = aa < 10;
            bool cc2 = aa > 20;
            bool cc3 = aa > 10;
            bool cc4 = aa > 5;
            Console.WriteLine(cc1);
            Console.WriteLine(cc2);
            Console.WriteLine(cc3);
            Console.WriteLine(cc4);
            Console.WriteLine("------------------");

            bool cc5 = aa <= 10;
            bool cc6 = aa >= 10;
            bool cc7 = aa == 10;
            bool cc8 = aa != 10;
            
            Console.WriteLine(cc5);
            Console.WriteLine(cc6);
            Console.WriteLine(cc7);
            Console.WriteLine(cc8);

            // Operadores Lógicos 

            Console.WriteLine("------------------");

            bool ccc1 = 2 >3 && 4 != 5;
            bool ccc2 = 2 >3 || 4 != 5;
            bool ccc3 = !(2 >3) && 4 != 5;

            Console.WriteLine(ccc1);
            Console.WriteLine(ccc2);
            Console.WriteLine(ccc3);

            Console.WriteLine("------------------");

            bool ccc4 = 10 < 5;
            bool ccc5 = ccc2 || ccc3 && ccc4;
            Console.WriteLine(ccc5);

            // Estrutura condicional 

            Console.WriteLine("------------------");
            /* Console.WriteLine("Entre com um número inteiro");
            int xe = int.Parse(Console.ReadLine());

            if (xe % 2 == 0)
            {
                Console.WriteLine("Par!");
            } else
            {
                Console.WriteLine("Impar");
            } 

            Console.WriteLine("Qual o Horário atual");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            } else if (hora < 18){
                Console.WriteLine("Boa tarde!");
            } else
            {
                Console.WriteLine("Boa noite!");
            }

            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;

            if (preco > 100.0)
            {
                desconto = preco * 0.1;
            }
            Console.WriteLine(desconto);

            // Funções

            Console.WriteLine("Digite 3 números?");
            int nn1 = int.Parse(Console.ReadLine());
            int nn2 = int.Parse(Console.ReadLine());
            int nn3 = int.Parse(Console.ReadLine());

            if (nn1 > nn2 && nn1 > nn3)
            {
                Console.WriteLine("Maior = " + nn1);
            } else if (nn2 > nn3)
            {
                Console.WriteLine("Maior: " + nn2);
            } else
            {
                Console.WriteLine("Maior: " + nn3);
            }

            double resultadoq = Maior(nn1, nn2, nn3);
            Console.WriteLine("Maior = " + resultadoq); 

            Console.Write("Digite um numero: ");
            double xx = double.Parse(Console.ReadLine());

            double raiz = Math.Sqrt(xx);
            Console.WriteLine(raiz.ToString("f3")); 

            Console.Write("Digite um numero: ");
            double xx = double.Parse(Console.ReadLine());

            // Estrutura de repetição while

            while (xx >= 0.0)
            {
                double raiz = Math.Sqrt(xx);
                Console.WriteLine(raiz.ToString("f3"));
                Console.WriteLine("Digite outro número: ");
                xx = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Número Negativo! "); */

            // estrutura de repetição for


            Console.Write("Quantos números você vai digitar? ");
            int N = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= N; i++)
            {
                Console.Write($"{i}° Valor: ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.Write(" = " + soma);
            
        }

        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            } else if (b > c){
                m = b;
            } else {
                m = c;
            }

            return m;
        }
    }
}


