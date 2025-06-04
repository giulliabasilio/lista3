using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = -1;
            while (x <= 0)
            {
                Console.Write("Digite um valor positivo para X: ");
                x = int.Parse(Console.ReadLine());
                if (x <= 0)
                {
                    Console.WriteLine("Valor inválido!");
                }
            }

            Console.Write("Digite o valor A (início do intervalo): ");
            int a = int.Parse(Console.ReadLine());

            int b;
            Console.Write("Digite o valor B (fim do intervalo, maior que A): ");
            b = int.Parse(Console.ReadLine());

            while (b <= a)
            {
                Console.WriteLine("B deve ser maior que A!");
                Console.Write("Digite o valor B novamente: ");
                b = int.Parse(Console.ReadLine());
            }

            int i = b;
            while (i >= a)
            {
                Console.WriteLine(x + " x " + i + " = " + (x * i));
                i = i - 1;
            }
        }
    }
}
