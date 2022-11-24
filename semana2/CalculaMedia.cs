using System;

class Program
{
    static void Main(string[] args)
    {
        double notaAna = 6.8;
        double notaBia = 7.9;
        double notaCaio = 6.1;
        double notaDani = 10.0;
        double notaEli = 5.4;

        double media = (notaAna + notaBia + notaCaio + notaDani + notaEli) / 5;

        Console.WriteLine("A média da turma foi de: " + media);

        if (media > 7)
        {
            Console.WriteLine("Turma aprovada!");
        }

        Console.WriteLine("Aperte enter para encerrar ...");
        Console.ReadLine();
    }
}
