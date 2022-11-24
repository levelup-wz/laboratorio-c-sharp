using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira seu nome:");
        string? nome = Console.ReadLine();

        Console.WriteLine("\nInsira seu email:");
        string? email = Console.ReadLine();

        Console.WriteLine("\nOlá, {0}! Usuário {1} cadastrado!", nome, email);

        Console.WriteLine("\nAperte enter para encerrar ...");
        Console.ReadLine();
    }
}
