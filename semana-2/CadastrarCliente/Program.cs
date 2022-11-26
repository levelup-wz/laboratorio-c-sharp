using System;

class Programa
{
  static void Main(string[] args)
  {
    string? nome;
    string? email;

    Console.WriteLine("Digite seu nome:");
    nome = Console.ReadLine();

    Console.WriteLine("Digite seu email:");
    email = Console.ReadLine();

    Console.WriteLine("Olá " + nome + "! " + "Usuário " + email + " cadastrado!");
  }
}
