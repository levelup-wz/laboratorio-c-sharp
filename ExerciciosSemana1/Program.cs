// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! \n");

#region CalcularMediaNotas
Console.WriteLine("Calcular média e aprovação da turma \n");

double notaAna = 6.8;
double notaBia = 7.9;
double notaCaio = 6.1;
double notaDani = 10;
double notaEli = 5.4;

double somaDasNotas = notaAna + notaBia + notaCaio + notaDani + notaEli;
double mediaDasNotas = somaDasNotas / 5;

global::System.Console.WriteLine($"A média da turma foi de: {mediaDasNotas}\n");

if (mediaDasNotas > 7)
{
    global::System.Console.WriteLine("Turma aprovada!\n");
}
else
{
    global::System.Console.WriteLine("Turma reprovada!");
}
#endregion

#region NumerosImpares
Console.WriteLine("Imprimir os números ÍMPARES de 1 a 100 \n");

Console.WriteLine("Números ímpares no Laço FOR");
for (int i = 0; i <= 100; i += 1)
{
    if (i % 2 == 1)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("\n Números ímpares no Laço WHILE");
int j = 0;
while (j <= 100)
{   
    if (j % 2 == 1)
    {
        Console.WriteLine(j);
    }
    j++;
}
#endregion

#region Soma1a100
Console.WriteLine("Imprimir a soma de 1 a 100 \n");

Console.WriteLine("Imprimir a soma de 1 a 100 no laço for \n");

int soma = 0;
for( int i = 0; i <= 100; i += 1)
{
    soma += i;
}
Console.WriteLine($"A soma dos números de 1 a 100 no laço FOR é {soma} \n");

int somaWhile = 0;
int count = 0;
while (count <= 100)
{
    somaWhile += count;
    count++;
}
Console.WriteLine($"A soma dos números de 1 a 100 no laço WHILE é {somaWhile} \n");

#endregion

#region Fibonacci

Console.WriteLine("Sequência Fibonacci com FOR");
int fiboA = 0;
int fiboB = 1;
int fiboSoma;

for (int i = 0; i < 20; i += 1)
{   
    fiboSoma = fiboA + fiboB;
    fiboA = fiboB;
    fiboB = fiboSoma;
    Console.WriteLine(fiboA);
}

Console.WriteLine("\n Sequência Fibonacci com WHILE");
int fiboAw = 0;
int fiboBw = 1;
int fiboSomaw;
count = 0;

while(count < 20)
{
    fiboSomaw = fiboAw + fiboBw;
    fiboAw = fiboBw;
    fiboBw = fiboSomaw;
    Console.WriteLine(fiboAw);
    count++;
}

Console.WriteLine(" \n Sequência Fibonacci com FOR com 2 variáveis");
int fiboForA = 1;
int fiboForSoma = 0;

for (int i = 0; i <= 20; i += 1)
{
    fiboForSoma += fiboForA;
    fiboForA = fiboForSoma - fiboForA;
    Console.WriteLine(fiboForA);
}
#endregion

#region Cadastro de Cliente
Console.WriteLine("\n**********************************");
Console.WriteLine("Bem vindo ao LevelUp - Wiz - Alura");
Console.WriteLine("****** Cadastro de Clientes ******\n");
Console.Write("Digite nome do Cliente: ");
string nomeCliente = Console.ReadLine();
Console.Write("Digite o email do Cliente: ");
string emailCliente = Console.ReadLine();
Console.WriteLine($"\nOlá, {nomeCliente}! Usuário {emailCliente} cadastrado!");
Console.WriteLine("\n**********************************\n");
#endregion

#region Calcular equação de 2º grau
Console.WriteLine("Calculando a equação de 2º grau");
Console.Write("Digite o valor da variável a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Digite o valor da variável b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Digite o valor da variável c: ");
int c = int.Parse(Console.ReadLine());

double valueRaiz = Math.Pow(b, 2) - 4 * a * c;
double raizValue1 = Math.Sqrt(valueRaiz);
double xPositivo = (-b + raizValue1) / (2 * a);
double xNegativo = (-b - raizValue1) / (2 * a);
Console.WriteLine($"As raízes das variáveis a = {a}, b = {b}, c = {c} são: {xPositivo} e {xNegativo}");

#endregion

#region Calcular Imc
Console.WriteLine("\n Calculo do IMC");
Console.Write("Digite seu peso: ");
double peso = double.Parse(Console.ReadLine());
Console.Write("Digite sua altura: ");
double altura = double.Parse(Console.ReadLine());
double imc = Math.Round((peso / (altura * altura)) * 10000, 2);
Console.WriteLine($"Dados informados: Peso: {peso}, Altura: {altura}");
Console.WriteLine($"Seu IMC é de: {imc}");
if (imc > 40.0)
{
    Console.WriteLine("Cuidado! Obesidade Grave");
}
else if (imc > 30)
{
    Console.WriteLine("Cuidado! Obesidade");
}
else if (imc > 25)
{
    Console.WriteLine("Sobrepeso");
}
else if (imc > 18.5)
{
    Console.WriteLine("Normal");
}
else
{
    Console.WriteLine("Abaixo do peso");
}

#endregion
