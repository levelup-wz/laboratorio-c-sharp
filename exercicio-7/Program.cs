// Calcular IMC

string input = "";
float peso = 0;
float altura = 0;
float imc = 0;

Console.Write("Calcular IMC\n\n");
Console.Write("Insira o seu peso: ");
input = Console.ReadLine();
peso = Convert.ToSingle(input);

Console.Write("Insira a sua altura: ");
input = Console.ReadLine();
altura = Convert.ToSingle(input);


imc = peso / (altura * altura);
Console.WriteLine($"Seu IMC é: {imc}");