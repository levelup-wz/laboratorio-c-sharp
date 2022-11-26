using System;

class Programa
{
  static void Main(string[] args)
  {
    // usando o laço for
    for (int i = 1; i <= 100; i++)
    {
      if (i % 2 != 0)
      {
        Console.WriteLine(i);
      }
    }

    // usando while
    int numero = 1;
    while (numero <= 100)
    {
      if (numero % 2 != 0)
      {
        Console.WriteLine(numero);
      }
      numero++;
    }
  }
}
