using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;
            int cont = 1;

            Console.WriteLine(a);

            while (cont < 30)
            {
                Console.WriteLine(b);
                int temp = a + b;
                a = b;
                b = temp;
                cont = cont + 1;
            }
        }
    }
}
