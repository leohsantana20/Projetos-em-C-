using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMaiorIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1;
            Pessoa p2;
            Pessoa p3;

            Console.WriteLine("Determinando qual pessoa é a mais velha");

            p1 = new Pessoa();
            Console.WriteLine("Nome da primeira pessoa:");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Idade da primeira pessoa:");
            p1.Idade = Convert.ToInt32(Console.ReadLine());

            p2 = new Pessoa();
            Console.WriteLine("Nome da segunda pessoa:");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Idade da segunda pessoa:");
            p2.Idade = Convert.ToInt32(Console.ReadLine());

            p3 = new Pessoa();
            Console.WriteLine("Nome da terceira pessoa:");
            p3.Nome = Console.ReadLine();
            Console.WriteLine("Idade da terceira pessoa:");
            p3.Idade = Convert.ToInt32(Console.ReadLine());

           // Saber quem é mais velho
           
            if (( p1.Idade > p2.Idade ) && ( p1.Idade > p3.Idade ))
            {
                Console.WriteLine("A pessoa mais velha é:");
                p2.ExibirDados();
            }
            else
            {
                if ((p2.Idade > p3.Idade) && (p2.Idade > p1.Idade))
                {
                    Console.WriteLine("A pessoa mais velha é:");
                    p2.ExibirDados();
                }
                else
                {
                    if ((p3.Idade > p1.Idade) && (p3.Idade > p2.Idade))
                    {
                        Console.WriteLine("A pessoa mais velha é:");
                        p3.ExibirDados();
                    }
                    else
                    {
                        Console.WriteLine("Todas as pessoas possuem a mesma idade.");
                    }
                }
            }
            
            Console.ReadKey();
        }
    }
}
