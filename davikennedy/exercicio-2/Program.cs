// Imprimir os números ÍMPARES de 1 a 100

// Resolução com 'for'
Console.WriteLine("Usando o laço 'for':");
for (int i = 1; i <= 100; i++) {
    if (i % 2 != 0) {
        Console.WriteLine(i);
    }
}

// Resolução com 'while'
Console.WriteLine("\nUsando o laço 'while':");
int j = 1;
while (j < 100) {
    if (j % 2 != 0) {
        Console.WriteLine(j);
    }
    j++;
}