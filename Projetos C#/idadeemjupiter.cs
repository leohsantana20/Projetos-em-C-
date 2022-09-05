using System;

namespace PlanetCalculations
{
    public class Program
    {
        public static void Main(String[] args)
        {
            int suaIdade = 23;
            double anosEmJupiter = 11.86;
            double tempoParaJupiter = 6.142466;

        // Idade em Jupiter
        double idadeEmJupiter = suaIdade / anosEmJupiter;

        // Nova idade na Terra
        double novaIdadeTerra = suaIdade + tempoParaJupiter;

        // Nova idade em Jupiter
        double novaIdadeJupiter = novaIdadeTerra / anosEmJupiter;

        Console.WriteLine(novaIdadeTerra);
        Console.WriteLine(novaIdadeJupiter);


        }
    }
}