using System;
class Programa
{
    static void Main(string[] args)
    
    {
        int i;

        Console.WriteLine("Números Impares de 1 a 100 com o laço FOR");
        for (i = 0; i <= 100; i++)
        {
            
            if (i % 2 == 1) //se o resto da divisão for = 1 são impares, então eles são impressos
            {
                Console.WriteLine(i);
       
            }
        }
        Console.WriteLine("Números Impares de 1 a 100 com o laço WHILE");

        i = 0;

        while (i <= 100)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine(i);

            }
         i++;
        }


        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();


    }
}
