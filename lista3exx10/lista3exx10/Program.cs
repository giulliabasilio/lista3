using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3exx10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double valor;
            double soma = 0;
            double maior = 0;
            int i = 0;

            while (i < 10)
            {
                Console.WriteLine("Digite um valor positivo:");
                valor = double.Parse(Console.ReadLine());

                if (valor > 0)
                {
                    soma = soma + valor;

                    if (i == 0)
                    {
                        maior = valor;
                    }
                    else
                    {
                        if (valor > maior)
                        {
                            maior = valor;
                        }
                    }

                    i = i + 1;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Tente novamente.");
                }
            }

            double media = soma / 10;

            Console.WriteLine("Maior valor: " + maior);
            Console.WriteLine("Soma dos valores: " + soma);
            Console.WriteLine("Média aritmética: " + media);
        }
    }
}
    
