using System;

namespace Review
{
  public class Program
  {
    public static void Main(string[] args)
    {

// Programa 1 Mostrar nome, idade, e local onde mora
  Console.WriteLine("Digite o seu nome: ");
  string name = Console.ReadLine();

  Console.WriteLine("Digite sua Idade: ");
  string age = Console.ReadLine();

  Console.WriteLine("Digite a cidade ou estado em que você mora: ");
  string local = Console.ReadLine();
 

// Programa 2 Print de Algumas informações

    string  myName = "Leonardo Henrique";
    int myAge= 23;
    double myBirthday = 20.03;
    string myLocation = "Pindamonhangaba - SP";

    Console.WriteLine(myName);
    Console.WriteLine(myAge);
    Console.WriteLine(myBirthday);
    Console.WriteLine(myLocation);

// Conversão de Tipos de Dados usando conversão implícita e explícita

    Console.WriteLine("Aqui está um exemplo de conversão implícita!");
    int myNumber = 20;
    double myNumberDouble = myNumber;

//////////////////////////////////////////////////////////////////////
    
    Console.WriteLine("Aqui está um exemplo de conversão explícita!");
    double myDoubleNum = 10.5;
    int myIntNum = (int)myDoubleNum;
    Console.WriteLine(myIntNum);

//////////////////////////////////////////////////////////////////////

    Console.WriteLine("Aqui está um exemplo de conversão usando Convert.TOx sendo 'X' o tipo de dado que você que realizar a conversão");

     Console.WriteLine("Digite aqui um número: ");
    string RandomNumber = Console.ReadLine();

    int newNumber = Convert.ToInt32(RandomNumber);
	  Console.WriteLine(newNumber);

// Conversão básica usando o COnvert.TO, para saber mais entre nesse artigo (https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number).
    }
  }
}
