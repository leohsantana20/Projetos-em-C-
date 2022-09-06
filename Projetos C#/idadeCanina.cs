using System;

namespace DogYears
{
    public class Program
    {
        public static void Main(String[] args)
        {

    // Descobrir a diferença de um ano canino para um ano humano

        int idadeMediaHumano = 80; // Valor pode ser alterado pelo qual você desejar
		int idadeMediaCachorroGrande = 12;  // Valor pode ser alterado pelo qual você desejar
		int idadeMediaCachorroPequeno = 17;  // Valor pode ser alterado pelo qual você desejar
			
		int minhaIdadeCachorroGrande = idadeMediaHumano / idadeMediaCachorroGrande ;
		int minhaIdadeCachorroPequeno = idadeMediaHumano / idadeMediaCachorroPequeno ;
			
			Console.WriteLine(minhaIdadeCachorroGrande);
			Console.WriteLine(minhaIdadeCachorroPequeno);

    // idade do cachorro em relação a idade humana

        int idadeCachorro = 5; // Idade do cachorro vai no valor da variavél
        int mediaCachorroGrande = minhaIdadeCachorroGrande;
        int mediaCachorroPequeno = minhaIdadeCachorroPequeno;

        int resultadoCachorroGrande = idadeCachorro * mediaCachorroGrande;
        Console.WriteLine(resultadoCachorroGrande);

        int resultadoCachorroPequeno  = idadeCachorro * minhaIdadeCachorroPequeno;
        Console.WriteLine(resultadoCachorroPequeno);

    // idade de um humano em anos caninos

        int idadeHumano = 23; // Valor pode ser alterado pelo qual você desejar
        int mCachorroGrande = minhaIdadeCachorroGrande;
        int mCachorroPequeno = minhaIdadeCachorroPequeno;

        int idadeHumanaCG = idadeHumano * mCachorroGrande;
        Console.WriteLine(idadeHumanaCG);

        int idadeHumanaCP = idadeHumano * mCachorroPequeno;
        Console.WriteLine(idadeHumanaCP);

        }
    }
    
}