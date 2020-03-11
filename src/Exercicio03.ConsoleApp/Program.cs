using System;

namespace Exercicio03.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.Write("Digite o nome do produto: ");
            var nome =  Console.ReadLine();
            Console.Write("Digite o valor unitario do produto: ");
            var valorUnitario = Console.ReadLine();
            Console.Write("Digite o desconto que deseja aplicar: ");
            var descontoReadLine = Console.ReadLine();
            float.TryParse(valorUnitario, out var valor);
            float.TryParse(descontoReadLine, out var desconto);

            var valorLiquido = valor - (valor * (desconto)/100);

            Console.WriteLine($"{nome} com {desconto}% de desconto = R${valorLiquido}");


        }
    }
}
