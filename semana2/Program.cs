
// double ana = 6.1;
// double bia = 7.9;
// double caio = 6.1;
// double dani = 10;
// double eli = 5.4;

// double total = ana + bia + caio + dani + eli;

// double media = total / 5;

// if (media > 7)
//     Console.WriteLine($"Turma aprovada com media {media}");



// programa com laco for
// for (int i = 0; i < 100; i++)
// {
//     if (i%2 == 1)
//         Console.WriteLine($">> {i}");
// }


// Console.WriteLine("Fazendo loop com while");
// int i = 0;
// while (i < 100)
// {
//     if (i%2 == 1)
//         Console.WriteLine($">> {i}");
//     i++;
// }

// int soma = 0;
// for (int i = 0; i <= 100; i++)
// {
//     soma += i;
// }
// Console.WriteLine($"A soma de 1 a 100 é: {soma}");

//1 1 2 3 5 8 13
// int primeiro = 0;
// int segundo = 1;
// for (int i = 0; i <= 20; i++)
// {
//     if (i == 1)
//         Console.WriteLine(1);
//     else {
//         segundo = primeiro + segundo;
//         primeiro = segundo - primeiro;
//         Console.WriteLine(segundo);
//     }

// }


//Bhaskara
// int a = 12;
// int b = 3;
// int c = -9;

// double delta = (b * b) - (4 * a * c);
// double raiz = Math.Sqrt(delta);
// double x1 = ((-(b)) + raiz) / (2 * a);
// double x2 = ((-(b)) - raiz) / (2 * a);

// Console.WriteLine($"X': {x1}");
// Console.WriteLine($"X'': {x2}");


// string nome = "Alex";
// string messagem = "Ola!";
// char quebraLinha = (char)10;

// Console.WriteLine(messagem + " " + nome);

// Console.WriteLine($"{messagem} bem vindo {nome} honra ter vc aqui hoje {DateTime.Now}");

// Console.Write("Allexxx" + quebraLinha);

// Console.WriteLine(@"Alex Ola");

Console.Write("Escreva uma letra maiuscula: ");

char input = (char)Console.Read(); //"A";

if (input < 65 || input > 90)
    Console.WriteLine($"Voce digitou caracter invalido");
else
    Console.WriteLine($"Voce digitou maisculo");

// for (int i = 65; i <= 90; i++)
// {
//     if (Int32.Parse(input) == i) {
//         Console.WriteLine($"Voce digitou maisculo");
//     }
//     else
//     {
//         Console.WriteLine($"Voce um caracter invalido");
//     }
// }

// Console.WriteLine($"Voce escreveu {input}");
