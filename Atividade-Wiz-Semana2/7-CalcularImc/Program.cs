using System;
class Programa
{
    static void Main(string[] args)
    {
        float massa, altura, imc;

        Console.WriteLine("Índice de Massa Corporal (IMC): ");
        Console.Write("Qual é o seu peso atual?: ");
        massa = float.Parse(Console.ReadLine());
        Console.Write("Qual é a sua altura?: ");
        altura = float.Parse(Console.ReadLine());

        imc = massa / (altura * 2);

        Console.WriteLine("Seu IMC: " + imc);

        if (imc < 17)
        {
            Console.WriteLine("Você está muito abaixo do peso!");
        }
        else if (imc >= 17 && imc < 18.5)
        {
            Console.WriteLine("Você está abaixo do peso.");

        }
        else if (imc >= 18.5 && imc < 25)
        {
            Console.WriteLine("Você está no peso ideal.");
        }
        else if (imc >= 25 && imc < 30)
        {
            Console.WriteLine("Você está com sobrepeso.");
        }
        else if (imc >= 30 && imc < 35)
        {
            Console.WriteLine("Você está com obesidadew.");
        }
        else
        {
            Console.WriteLine("Obesidade morbida!");
        }
        Console.Write("\n\n");

        Console.WriteLine("tecle enter para fechar o programa...");
        Console.ReadLine();
    }
}