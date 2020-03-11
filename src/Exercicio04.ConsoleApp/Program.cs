using System;

namespace Exercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite o tamanho da base: ");
            var a = Console.ReadLine();
            Console.Write("Digite a altura: ");
            var h = Console.ReadLine();
            Console.WriteLine($"Área do triangulo = {(float.Parse(a)*float.Parse(h))/2}");

        }
    }
}
