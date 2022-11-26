using System;

class Programa
{
  static void Main(string[] args)
  {
    // resolvido com 3 variáveis
    int anterior = 0;
    int atual = 1;
    int proximo = 0;

    for (int i = 0; i < 20; i++)
    {
      // Console.WriteLine(atual);
      proximo = anterior + atual;
      anterior = atual;
      atual = proximo;
    }

    // resolvido com 2 variáveis
    int actual = 1;
    int next = 1;

    for (int i = 0; i < 20; i++)
    {
      Console.WriteLine(actual);
      next = actual + next;
      actual = next - actual;
    }
  }
}
