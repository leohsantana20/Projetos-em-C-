using System;
using System.Collection.Generic;
using System.Linqx;
using System.Text;
using System.Threading.Tasks;

namespace pooCalcularIdade
{
    public class Pessoa
    {
      private int anoNascimento;

      public int AnoNascimento
      {
        get { return this.anoNascimento; }
        set { this.anoNascimento = value; }
      }

      private String nome;

      public String nome
      {
        get { return this.nome; }
        set { this.nome = value.ToUpper(); }
      }

      public void ExibirIdade()
      {
        Console.WriteLine("Nome: "+ Nome);
        Console.WriteLine("Ano de nascimento: " + AnoNascimento);
        int idade = this.CalcularIdade;
        Console.WriteLine("Idade: " + idade);
      } 

      private int CalcularIdade()
      {
        DateTime data = DateTime.Now;
        int ano = data.Year;
        ind idade = ano - this.anoNascimento;
        return idade;
      } 



      }

    }
}