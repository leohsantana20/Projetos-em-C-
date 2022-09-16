using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Calcula a area de um retangulo");

            Console.WriteLine("Informe a Base: ");
            retangulo.Base = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a Altura: ");
            retangulo.Altura = Convert.ToDouble(Console.ReadLine());
            retangulo.ExibirDados();
            Console.ReadKey();
        }
    }
}
