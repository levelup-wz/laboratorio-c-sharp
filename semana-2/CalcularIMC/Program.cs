using System;

class Programa
{
  static void Main(string[] args)
  {
    double peso;
    double altura;
    double imc;

    Console.WriteLine("Digite seu peso: ");
    peso = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite sua altura: (exemplo: 1,75)");
    altura = Convert.ToDouble(Console.ReadLine());

    imc = peso / (altura * altura);

    Console.WriteLine("Seu IMC é: " + imc);

    switch (imc)
    {
      case < 17:
        Console.WriteLine("Muito abaixo do peso");
        break;
      case < 18.5:
        Console.WriteLine("Abaixo do peso");
        break;
      case < 25:
        Console.WriteLine("Peso normal");
        break;
      case < 30:
        Console.WriteLine("Acima do peso");
        break;
      case < 35:
        Console.WriteLine("Obesidade grau 1");
        break;
      case < 40:
        Console.WriteLine("Obesidade grau 2");
        break;
      default:
        Console.WriteLine("Obesidade grau 3");
        break;
    }
  }
}
