using System;
using System.Globalization;

class Programa
{
    static void Main(string[] args)

    {
        string nome;
        string email;

        Console.WriteLine("Digite o seu nome: ");
        nome =  Console.ReadLine(); //A variavel recebe o valor digitado (o valor r salvo na forma de string)
        Console.WriteLine("Digite o seu email: ");
        email = Console.ReadLine();

        Console.WriteLine("Olá, "  + nome + "! Usuário " + email + " cadastrado!");




        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();


    }
}

