using System;

namespace ChecarSenha
{
    public class Program
    {
        public static void Main(string[] args)
        {

        // Checa a senha do usuário e da o resultado usando interpolação de variáveis, note que usa método antigo e desatualizado.
        
            Console.WriteLine("Digite sua senha abaixo...");
            string senha = Console.ReadLine();
            int tamanhoSenha = senha.Length;

            if (tamanhoSenha >= 8){;
                Console.WriteLine("Senha Aceita!");
            }

            else {; 
                Console.WriteLine("Digite uma senha com no mínimo 8 caractéres!");
            }

            int checarSimbolo = senha.IndexOf("!, ?, @");

            Console.WriteLine($"A senha do usuário é {senha}. E o tamanho é de {tamanhoSenha} caractéres, e apresenta este {checarSimbolo} símbolo.");

        }
    }
}