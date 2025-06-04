using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            while (num <= 20)
            {
                int i = 1;
                while (i <= 10)
                {
                    Console.WriteLine(num + " x " + i + " = " + (num * i));
                    i = i + 1;
                }

                Console.WriteLine("Pressione uma tecla para continuar...");
                Console.ReadKey();

                num = num + 1;
            }
        }
    }
}
    
