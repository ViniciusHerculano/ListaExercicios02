using System.Linq;
using System.Collections.Generic;
using System;


namespace Exercicio06.Consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<float>();

            for (int i = 0; i < 4; i++)
            {
                var notaRequisitada = i + 1;
                Console.Write($"Digite a {notaRequisitada}º nota do Aluno: ");
                var notaReadLine = Console.ReadLine();
                float.TryParse(notaReadLine, out var nota);

                lista.Add(nota);
            }

            var media = lista.Average();
            Console.WriteLine($"Média do Aluno: {Math.Round(media, 3)}");


        }
    }
}
