using System;
using System.Collection.Generic;
using System.Linqx;
using System.Text;
using System.Threading.Tasks;

namespace pooCalcularIdade
{
    public class Program
    {
        static void Mains(String [] args)
        {
            Console.WriteLine("Programa para calcular idade!");
            Pessoa p = new Pessoa();
            Console.WriteLine("Escreva o nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Escreva o ano do nascimento: ");
            p.AnoNascimento = Console.ReadLine();
            p.AnoNascimento = Convert.ToInt32(Console.ReadLine());
            p.ExibirIdade();
            Console.ReadKey();
        }
    }
}
