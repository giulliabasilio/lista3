using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeiro;
            int segundo;

            Console.Write("Digite o primeiro valor: ");
            primeiro = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor (maior que o primeiro): ");
            segundo = int.Parse(Console.ReadLine());

            while (segundo <= primeiro)
            {
                Console.WriteLine("Erro! O segundo valor deve ser maior que o primeiro.");
                Console.Write("Digite o segundo valor novamente: ");
                segundo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Valores corretos digitados.");
        }
    }
    }

