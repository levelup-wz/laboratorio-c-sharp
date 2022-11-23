// Calcular média e aprovação da turma

double[] notas = { 6.8, 7.9, 6.1, 10, 5.4 };
double somaNotas = 0;

foreach(double nota in notas) {
    somaNotas += nota;
}
double mediaNotas = somaNotas / notas.Length;

Console.WriteLine($"A média da turma foi de {mediaNotas}");

if (mediaNotas > 7) {
    Console.WriteLine("Turma aprovada!");
}