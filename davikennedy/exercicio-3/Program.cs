// Imprimir a soma dos números de 1 a 100


// Resolução com 'for'
int soma = 0;

Console.WriteLine();
for (int i = 0; i <= 100; i++) {
    soma += i;
}
Console.WriteLine($"Usando o laço 'for': {soma}");

// Resolução com 'while'
soma = 0;
int j = 0;

while (j <= 100) {
    soma += j;
    j++;
}
Console.WriteLine($"Usando o laço 'while': {soma}");