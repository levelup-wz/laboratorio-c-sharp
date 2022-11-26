using System;

class Programa
{
  static void Main(string[] args)
  {
    // usando o laço for
    int soma = 0;
    for (int i = 1; i <= 100; i++)
    {
      soma = soma + i;
    }
    Console.WriteLine(soma);

    // usando while
    int number = 1;
    int sum = 0;
    while (number <= 100)
    {
      sum += number;
      number++;
    }
    Console.WriteLine(sum);
  }
}
