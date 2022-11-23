using System;
using System.Security.Cryptography;

class Programa
{
    static void Main(string[] args)
    {
        float Ana = 6.8f, Bia = 7.9f, Caio = 6.1f, Dani = 10f, Eli = 5.4f, soma, media;

        soma = Ana + Bia + Caio + Dani + Eli;
        media = soma / 5;

        Console.WriteLine("A média da turma foi de " + media);

        if (media > 7)
        {
            Console.WriteLine("Turma aprovada!");
        }
        else
        {
            Console.WriteLine("Turma reprovada!");
        }
        Console.Write("\n");

        Console.WriteLine("Tecle enter para fechar o programa...");
        Console.ReadLine();
    }
}