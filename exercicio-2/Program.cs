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
int i = 1;
while (i < 100) {
    if (i % 2 != 0) {
        Console.WriteLine(i);
    }
    i++;
}