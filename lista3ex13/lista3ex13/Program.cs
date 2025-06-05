using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta;

            do
            {
                int n;
                long fatorial = 1;

                do
                {
                    Console.WriteLine("Digite um número não negativo para calcular o fatorial:");
                    n = int.Parse(Console.ReadLine());

                    if (n < 0)
                    {
                        Console.WriteLine("Valor inválido. Tente novamente.");
                    }

                } while (n < 0);

                fatorial = 1;

                for (int i = n; i >= 1; i--)
                {
                    fatorial = fatorial * i;
                }

                Console.WriteLine("Fatorial de " + n + " é: " + fatorial);

                do
                {
                    Console.WriteLine("Deseja fazer um novo cálculo? (S/N)");
                    resposta = Console.ReadLine().ToUpper();

                    if (resposta != "S" && resposta != "N")
                    {
                        Console.WriteLine("Resposta inválida. Digite apenas S ou N.");
                    }

                } while (resposta != "S" && resposta != "N");

            } while (resposta == "S");
        }
    }
}
    
