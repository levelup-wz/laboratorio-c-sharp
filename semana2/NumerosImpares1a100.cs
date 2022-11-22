using System;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Usando o laço for:");

		for (int i = 1; i <= 100; i++)
		{
			if (i % 2 != 0)
			{
				Console.Write(i + " ");
			}
		}

		Console.WriteLine("\n\nUsando o laço while:");

		int num = 1;

		while (num <= 100)
		{
			if (num % 2 != 0)
			{
				Console.Write(num + " ");
			}

			num++;
		}

		Console.WriteLine("\n\nAperte enter para encerrar ...");
		Console.ReadLine();
	}
}
