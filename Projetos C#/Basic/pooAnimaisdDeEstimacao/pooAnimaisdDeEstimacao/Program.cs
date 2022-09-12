using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooAnimaisdDeEstimacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal();
            Animal a3 = new Animal();
            Animal a4 = new Animal();
            Animal a5 = new Animal();
            int tlCachorro = 0, tlGato = 0, tlPeixe = 0;


            Console.WriteLine("Controle de Animais");
           
            // Primeiro Animal
            Console.Write("Informe o nome do primeiro animal: ");
            a1.Nome = Console.ReadLine();

            Console.WriteLine("Informe o tipo do primeiro animal: ");
            a1.Tipo = Console.ReadLine();
            if (a1.Tipo == "Cachorro") tlCachorro++ ;
            if (a1.Tipo == "Gato") tlGato++;
            if (a1.Tipo == "Peixe") tlPeixe++;

            // Segundo Animal
            Console.Write("Informe o nome do segundo animal: ");
            a2.Nome = Console.ReadLine();

            Console.WriteLine("Informe o tipo do segundo animal: ");
            a2.Tipo = Console.ReadLine();
            if (a2.Tipo == "Cachorro") tlCachorro++;
            if (a2.Tipo == "Gato") tlGato++;
            if (a2.Tipo == "Peixe") tlPeixe++;


            // Terceiro Animal
            Console.WriteLine("Informe o nome do terceiro animal: ");
            a3.Nome = Console.ReadLine();

            Console.WriteLine("Informe o tipo do terceiro animal: ");
            a3.Tipo = Console.ReadLine();
            if (a3.Tipo == "Cachorro") tlCachorro++;
            if (a3.Tipo == "Gato") tlGato++;
            if (a3.Tipo == "Peixe") tlPeixe++;

            // Quarto Animal
            Console.WriteLine("Informe o nome do quarto animal: ");
            a4.Nome = Console.ReadLine();

            Console.WriteLine("Informe o tipo do quarto animal: ");
            a4.Tipo = Console.ReadLine();
            if (a4.Tipo == "Cachorro") tlCachorro++;
            if (a4.Tipo == "Gato") tlGato++;
            if (a4.Tipo == "Peixe") tlPeixe++;

            // Quinto Animal
            Console.WriteLine("Informe o nome do quinto animal: ");
            a5.Nome = Console.ReadLine();

            Console.WriteLine("Informe o tipo do quinto animal: ");
            a5.Tipo = Console.ReadLine();
            if (a5.Tipo == "Cachorro") tlCachorro++;
            if (a5.Tipo == "Gato") tlGato++;
            if (a5.Tipo == "Peixe") tlPeixe++;

            //Resultado
            Console.WriteLine("Total de animais");
            Console.WriteLine("Cachorros: " +tlCachorro+ " \nGatos: " +tlGato+ " \nPeixe: " + tlPeixe);
            Console.ReadKey();

        }
    }
}
