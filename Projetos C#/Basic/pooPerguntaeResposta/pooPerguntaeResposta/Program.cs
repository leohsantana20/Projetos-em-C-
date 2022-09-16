using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPerguntaeResposta
{
    public class Program
    {
        static void Main(string[] args)
        {
            PerguntaP p = new PerguntaP();
            p.Texto = "Qual o seu nome:";
            p.Resposta = "Meu nome é Leonardo.";
            p.Dica = "Começa com L.";

            Console.WriteLine("Advinhe a pergunta");
            Console.WriteLine("Pergunta: " + p.Texto);
            Console.WriteLine("Dica: " + p.Dica);
            Console.Write("Resposta: ");
            String resposta = Console.ReadLine();

            if (p.Resposta.ToUpper() == resposta.ToUpper())
            {
                Console.WriteLine("Parabéns vocÊ acertou!");
            }
            else
            {
                Console.WriteLine("Você errou");
                Console.WriteLine("A resposta certa é: " + p.Resposta);
            }
            Console.ReadKey();
        }
    }
}
