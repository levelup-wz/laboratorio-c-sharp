// Calcular equação de 2º grau

string input = "";
int a, b, c = 0;
double delta, x1, x2 = 0;

Console.WriteLine("Cálculo de equações do 2º grau");

Console.Write("Insira o valor de a: ");
input = Console.ReadLine();
a = Convert.ToInt32(input);

Console.Write("Insira o valor de b: ");
input = Console.ReadLine();
b = Convert.ToInt32(input);

Console.Write("Insira o valor de c: ");
input = Console.ReadLine();
c = Convert.ToInt32(input);

delta = Math.Pow(b, 2) - 4 * a * c;
x1 = (-b + Math.Sqrt(delta)) / (2 * a);
x2 = (-b - Math.Sqrt(delta)) / (2 * a);

Console.WriteLine("");
Console.WriteLine($"O valor de x¹ é: {x1}");
Console.WriteLine($"O valor de x² é: {x2}");