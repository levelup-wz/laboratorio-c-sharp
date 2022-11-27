using System;

class Programa
{
  static void Main(string[] args)
  {
    // Imprimir a sequência de Fibonacci até o vigésimo elemento:
   // 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765.
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
