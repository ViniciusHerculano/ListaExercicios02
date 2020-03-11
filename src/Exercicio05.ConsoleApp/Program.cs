using System;

namespace Exercicio05.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero para verificar se é par ou impar: ");
            var numReadLine = Console.ReadLine();
            int.TryParse(numReadLine, out var num);

            if(num % 2 == 0)
                Console.WriteLine($"O numero {num} é PAR.");
            else
                Console.WriteLine($"O numero {num} é IMPAR.");
        }
    }
}
