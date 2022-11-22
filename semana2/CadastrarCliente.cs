using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira seu nome:");
        string? nome = Console.ReadLine();

        Console.WriteLine("\nInsira seu email:");
        string? email = Console.ReadLine();

        Console.WriteLine("\nOlá, " + nome + "! Usuário " + email + " cadastrado!");

        Console.WriteLine("\nAperte enter para encerrar ...");
        Console.ReadLine();
    }
}
