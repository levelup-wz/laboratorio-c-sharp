int a = 0;
int b = 1;

for (int i = 0; i < 20; i += 1)
{
    int soma = a + b;
    a = b;
    b = soma;
    Console.WriteLine(a);
}
