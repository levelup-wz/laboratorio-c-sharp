
    using System;
class Programa
{
    static void Main(string[] args)
    {
        double somaNotas = 6.8 + 7.9 + 6.1 + 10 + 5.4;
        double media = somaNotas / 5;

        Console.WriteLine("A média da turma foi de: " + media);
        if (media >= 7)
        {
            Console.WriteLine("Turma aprovada!");
        }

    }

    Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
}