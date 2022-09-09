using System;

namespace IdentificacaoDoUsuario
{
public class Program
    {
    public static void Main(string[] args)
        {   

    // Realizar o Cadastro de um novo usuário e identifica se o mesmo atingiu a maioridade.

        Console.WriteLine("Digite as inbformações do usuário: ");
            string nomeDoUsuario = Console.ReadLine();
            int idadeDoUsuario = Convert.ToInt32(Console.ReadLine());
            int dia = Convert.ToString(Console.ReadLine());

            string verificaNome = nomeDoUsuario;
            int verificaIdade = idadeDoUsuario;

            if (verificaIdade >= 18) {
                Console.WriteLine("O usuário atingiu a maioridade!");
            
            }

            else if(verificaIdade <= 18) {
                Console.WriteLine("O usuário não atingiu a maioridade.");
                
            }

        }
    }
}