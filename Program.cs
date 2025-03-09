using System.Runtime.Intrinsics.Arm;
using Calculadora.Funcoes;

int opcao = 0;
int valor, fat = 0;
string binario;

do
{
    Console.Clear();
    Console.WriteLine("Calculadora");
    Console.WriteLine("1 - Fatorial");
    Console.WriteLine("2 - DecToBin");
    Console.WriteLine("3 - Fibonacci");
    Console.WriteLine("Informe a opção");
    opcao = int.Parse(Console.ReadLine());

    if (opcao == 0)
    {
        Console.WriteLine("Muito obrigado!");
    }
    else if ((opcao < 1) || (opcao > 3))
    {
        Console.WriteLine("Opção Inválida!");
    }
    else
    {
        if (opcao == 1)
        {
            Console.WriteLine("Informe um número para Fatorial");
            valor = int.Parse(Console.ReadLine());
            Fat.fatorial(valor, out fat);

            Console.WriteLine($"O resultado é: {fat}");
        }
        else if (opcao == 2)
        {
            Console.WriteLine("Informe um número inteiro para conversão:");
            valor = int.Parse(Console.ReadLine());
            binario = Dec.DecToBin(valor);

            Console.WriteLine($"O resultado da conversão é: {binario}");
        }
        else if (opcao == 3)
        {
            Console.WriteLine("Quantos termos de Fibonacci você quer? ");
            valor = int.Parse(Console.ReadLine());

            for (int i = 0; i < valor; i++)
            {
                Console.WriteLine(Fibo.Fibonacci(i));
            }
        }
    }

    Console.ReadKey();
} while (opcao != 9);