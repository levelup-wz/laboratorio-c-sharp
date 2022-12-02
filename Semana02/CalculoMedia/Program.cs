
    using System;
class Programa
{
    static void Main(string[] args)
    {
        double somaNotas = 6.8 + 7.9 + 6.1 + 10 + 5.4; //delcarando variavel e somando as notas
        double media = somaNotas / 5; //declarando variavel e fazendo a media 

        Console.WriteLine("A média da turma foi de: " + media);
        if (media >= 7)
        {
            Console.WriteLine("Turma aprovada!");
        }

    }

    Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
}