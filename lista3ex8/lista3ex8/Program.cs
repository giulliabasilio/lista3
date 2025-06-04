using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int i = 1;

            while (i <= 100)
            {
                soma = soma + i;
                i = i + 1;
            }

            Console.WriteLine("A soma de 1 até 100 é: " + soma);
        }
    }
}
    