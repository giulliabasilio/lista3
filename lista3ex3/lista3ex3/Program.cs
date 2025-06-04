using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sexo = "";

            while (sexo != "F" && sexo != "M")
            {
                Console.Write("Digite o sexo (F ou M): ");
                sexo = Console.ReadLine();

                if (sexo != "F" && sexo != "M")
                {
                    Console.WriteLine("Valor inválido.");
                }
            }

            Console.WriteLine("Sexo digitado: " + sexo);
        }
    }
}
