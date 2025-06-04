using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = -1;

            while (valor <= 0)
            {
                Console.Write("Digite um valor positivo: ");
                string entrada = Console.ReadLine();

                if (double.TryParse(entrada, out valor))
                {
                    if (valor <= 0)
                    {
                        Console.WriteLine("Erro: O valor deve ser maior que zero.");
                    }
                }
                else
                {
                    Console.WriteLine("Erro: Entrada inválida. Digite um número.");
                    valor = -1;
                }
            }

            Console.WriteLine($"Você digitou o valor: {valor}");
        }
}
    }

