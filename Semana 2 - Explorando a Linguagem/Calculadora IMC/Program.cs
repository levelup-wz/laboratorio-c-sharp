Console.WriteLine("Digite seu peso: ");
double peso = double.Parse(Console.ReadLine());

Console.WriteLine("Digite sua altura: ");
double altura = double.Parse(Console.ReadLine());

double imc = Math.Round(peso / Math.Pow(altura, 2),2);
Console.Write($"Seu IMC é: {imc} e sua situação é: ");

switch (imc)
{
    case < 18.5:
        Console.WriteLine("Abaixo do peso");
        break;
    case < 25:
        Console.WriteLine("Peso normal");
        break;
    case < 30:
        Console.WriteLine("Sobrepeso");
        break;
    case < 35:
        Console.WriteLine("Obesidade grau 1");
        break;
    case < 40:
        Console.WriteLine("Obesidade grau 2");
        break;
    default:
        Console.WriteLine("Obesidade grau 3");
        break;
}