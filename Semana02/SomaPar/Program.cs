// See httpsusing System;
class Programa
{
    static void Main(string[] args)

    {
        int i;
        int soma = 0;

        Console.WriteLine("Soma de números par de 1 a 100 com o laço FOR");
        for (i = 0; i <= 100; i++)
        {

            if (i % 2 == 0)
            {
                soma = soma + i;
                Console.WriteLine(soma);

            }
        }
        Console.WriteLine("Soma de núemros par de 1 a 100 com o laço WHILE");

        i = 0;
        soma = 0;

        while (i <= 100)
        {

            if (i % 2 == 0)
            {
                soma = soma + i;
                Console.WriteLine(soma);

            }
            i++;
        }


        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();


    }
}
