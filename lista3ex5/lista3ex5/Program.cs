using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3ex5
{
    internal class Program
    {
        static void Main(string[] args)
        { 
                 int valor = -1;

            while (valor <= 0)
            {
                Console.Write("Digite um valor positivo: ");
                valor = int.Parse(Console.ReadLine());

                if (valor <= 0)
                {
                    Console.WriteLine("Valor inválido!");
                }
            }

            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(valor + " x " + i + " = " + (valor * i));
                i = i + 1;
            }
        }
    }
}

