using System;


namespace Media_Turma
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, nota5, media;

            string alunosMedia = @"Alunos: 
-Ana. 
-Bia.
-Caio.
-Dani.
-Eli.";
            Console.WriteLine(alunosMedia);

            Console.WriteLine("Insira a 1ª nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a 2ª nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a 3ª nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a 4ª nota: ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a 5ª nota: ");
            nota5 = Convert.ToDouble(Console.ReadLine());

            media = Math.Round((nota1 + nota2 + nota3 + nota4 + nota5) / 5);

            if (media > 7.0)
            {
                Console.WriteLine("Turma Reprovada");

            }
            if (media <= 7.0)
            {
                Console.WriteLine("A média da turma foi de " + media);
            }

            Console.ReadKey();
            //Para tela ficar pausada na execução do programa.
        }
    }
}