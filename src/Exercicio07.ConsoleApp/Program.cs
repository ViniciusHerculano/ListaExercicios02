using System.Linq;
using System;
using System.Collections.Generic;

namespace Exercicio07.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var notas = new List<float>();

            for (int i = 0; i < 4; i++)
            {
                var notaRequisitada = i + 1;
                Console.Write($"Digite a {notaRequisitada}º nota do Aluno: ");
                var notaReadLine = Console.ReadLine();
                float.TryParse(notaReadLine, out var nota);

                notas.Add(nota);
            }

            var media = notas.Average();

            Console.Write("Quantidade de aulas no semestre: ");
            var qtdAulasReadLine = Console.ReadLine();
            Console.Write("Quantidade de faltas no semestre: ");
            var qtdFaltasReadLine = Console.ReadLine();

            int.TryParse(qtdAulasReadLine, out var qtdAulas);
            int.TryParse(qtdFaltasReadLine, out var qtdFaltas);

            var percentualPresente = ((qtdAulas - qtdFaltas)*100)/qtdAulas;

            if (percentualPresente >= 75 && media >= 5)
            {
                Console.WriteLine("O aluno foi aprovado!!");
                Console.WriteLine($"Presença: {percentualPresente}%");
                Console.WriteLine($"Média: {media}");
            }else{
                Console.WriteLine("O aluno foi reprovado!!");
                Console.WriteLine($"Presença: {percentualPresente}%");
                Console.WriteLine($"Média: {media}");
            }


        }
    }
}
