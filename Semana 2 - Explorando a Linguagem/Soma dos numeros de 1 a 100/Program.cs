Console.WriteLine("COM WHILE");
int numero = 1;
int soma = 0;
while(numero <= 100)
{
    soma += numero;
    numero+=1;
}
Console.WriteLine(soma);
Console.WriteLine("---------------------------------------------------------");

Console.WriteLine("COM FOR");
int soma2 = 0;
for(int i = 1; i <= 100; i++)
{
    soma2 += i;
}
Console.WriteLine(soma2);
Console.WriteLine("---------------------------------------------------------");
