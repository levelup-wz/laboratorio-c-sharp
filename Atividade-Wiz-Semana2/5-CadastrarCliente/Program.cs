using System;
class Programa
{
    static void Main(string[] args)
    {
        string nome, email;

        Console.WriteLine("Criar um novo cliente: ");
        Console.Write("Qual é o seu nome?: ");
        nome = Console.ReadLine();
        Console.Write("Qual é o seu email?: ");
        email = Console.ReadLine();

        Console.WriteLine("Olá, " + nome + "! Usuário " + email + " cadastrado!");

        Console.Write("\n");
        Console.WriteLine("Tecle enter para fechar o programa...");
        Console.ReadLine();
    }
}
