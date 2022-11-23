// Calcular IMC

string input = "";
float peso, altura, imc = 0;

Console.WriteLine("Calcular IMC");

Console.Write("Insira o seu peso: ");
input = Console.ReadLine();
peso = Convert.ToSingle(input);

Console.Write("Insira a sua altura: ");
input = Console.ReadLine();
altura = Convert.ToSingle(input);

imc = peso / (altura * altura);
Console.WriteLine($"Seu IMC é: {imc}");