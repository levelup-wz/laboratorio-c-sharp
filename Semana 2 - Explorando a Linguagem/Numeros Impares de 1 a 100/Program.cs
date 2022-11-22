using System;

Console.WriteLine("---------------------------------------------------------");
Console.WriteLine("COM WHILE");
Console.WriteLine("---------------------------------------------------------");

int numero = 1;
while (numero <= 100)
{
    if(numero % 2 == 1)
    {
       Console.WriteLine(numero);
       numero += 1;
    }
    else
    {
        numero += 1;
    }
}

Console.WriteLine("---------------------------------------------------------");
Console.WriteLine("COM FOR");
Console.WriteLine("---------------------------------------------------------");

int numero2 = 100;
for(int index = 1; index <= numero2; index++)
{
    if(index % 2 == 1)
    {
        Console.WriteLine(index);
    }
}