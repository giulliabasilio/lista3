using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double N;
            double valor;
            double soma = 0;
            double maior = 0;
            double menor = 0;
            int positivos = 0;
            int negativos = 0;

            // Validação de N
            do
            {
                Console.WriteLine("Digite a quantidade de valores (maior que 0 e menor que 20):");
                N = double.Parse(Console.ReadLine());

                if (N <= 0 || N >= 20)
                {
                    Console.WriteLine("Quantidade inválida. Tente novamente.");
                }

            } while (N <= 0 || N >= 20);

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite um valor:");
                valor = double.Parse(Console.ReadLine());

                soma = soma + valor;

                if (i == 0)
                {
                    maior = valor;
                    menor = valor;
                }
                else
                {
                    if (valor > maior)
                    {
                        maior = valor;
                    }

                    if (valor < menor)
                    {
                        menor = valor;
                    }
                }

                if (valor >= 0)
                {
                    positivos = positivos + 1;
                }
                else
                {
                    negativos = negativos + 1;
                }
            }

            double media = soma / N;
            double percPos = (positivos * 100) / N;
            double percNeg = (negativos * 100) / N;

            Console.WriteLine("Maior valor: " + maior);
            Console.WriteLine("Menor valor: " + menor);
            Console.WriteLine("Soma dos valores: " + soma);
            Console.WriteLine("Média aritmética: " + media);
            Console.WriteLine("Porcentagem de positivos: " + percPos + "%");
            Console.WriteLine("Porcentagem de negativos: " + percNeg + "%");
        }
    }
}
    }
}
