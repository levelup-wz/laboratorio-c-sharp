using System;

//solução para interação com char como entrada.
char letra;

Console.Write("Digite uma letra: ");
letra = char.Parse(Console.ReadLine()); // convertando oq foi digitado para char e armazenando na variavel.
Console.Write("\n");

Console.WriteLine(letra);

int convert = (int)letra; // convertendo a variavel para interiro.

Console.WriteLine(convert);

for (int i = convert; i <= convert; i++) // laço para definir se os char convertido em int está dentro dos requesitos.
{
    if (i >= 65 && i <= 90)
    {
        Console.WriteLine("Caractere válido!");
    }
    else
    {
        Console.WriteLine("Caractere inválido.");
    }
}
Console.Write("\n\n");


//solução para interação com string como entrada.
string frase;

Console.Write("Digite uma frase: ");
frase = Console.ReadLine();
Console.Write("\n");

char[] charArray = frase.ToCharArray();// convertendo uma string em um array de caracteres.

Console.WriteLine(string.Join(", ", charArray));// separando os caracteres com virgula.
Console.Write("\n");


for (int i = 0; i < charArray.Length; i++) // laço para leitura de cada caractere no array e converter cada um em inteiro.
{
    Console.WriteLine(charArray[i]);
    char caracter = charArray[i];
    int converte = (int)caracter;
    Console.WriteLine(converte);

    for (int j = converte; j <= converte; j++) // laço para definir se os char convertido em int está dentro dos requesitos 
    {
        if (j >= 65 && j <= 90)
        {
            Console.WriteLine("Caractere válido!");
        }
        else
        {
            Console.WriteLine("Caractere inválido.");
        }
    }
    Console.Write("\n");
}

Console.Write("\n");
Console.WriteLine("Tecle enter para fechar o programa...");
Console.ReadKey();