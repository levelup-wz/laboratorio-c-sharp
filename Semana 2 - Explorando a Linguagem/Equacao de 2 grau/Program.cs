int a = 12;
int b = 3;
int c = -9;

double delta = Math.Pow(b, 2) - 4 * a * c;
double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
Console.WriteLine($"XI: {x1}");
Console.WriteLine($"XII: {x2}");
