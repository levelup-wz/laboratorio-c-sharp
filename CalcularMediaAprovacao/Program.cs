using System;

class Programa
{
  static void Main(string[] args)
  {
    double ana = 6.8;
    double bia = 7.9;
    double caio = 6.1;
    double dani = 10.0;
    double eli = 5.4;

    double media = (ana + bia + caio + dani + eli) / 5;

    Console.WriteLine("A média da turma foi de " + media);

    if (media > 7)
    {
      Console.WriteLine("Turma aprovada!");
    }
  }
}