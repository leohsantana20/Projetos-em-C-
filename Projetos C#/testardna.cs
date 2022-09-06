using System;

namespace testarDNA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a Sequência do DNA:");

            string dnaSeq = Console.ReadLine();
            int tgaSeq = dnaSeq.IndexOf("TGA");

            int pontoDeInicio = 0;
            int tamanhoDNA = tgaSeq + 3;

            string dnaResultado = dnaSeq.Substring(pontoDeInicio, tamanhoDNA);
            Console.WriteLine(dnaResultado);

        // Supondo que o 5 caractére do DNA seja G ou T o mesmo sofre mutação.
        // Para verificar fazemos o seguinte.

        Console.WriteLine(dnaResultado[4] "Ouve mutação.");

        }
    }
}