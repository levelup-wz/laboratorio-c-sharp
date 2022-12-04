
using System;
using System.Runtime.CompilerServices;

class Programa
{
    static void Main(string[] args)
    {
        double imc, altura, peso;

        Console.WriteLine("Insira o peso");
        peso = double.Parse(Console.ReadLine()); //Recebe o valor digitado (string) e transforma ele para double e salva na vaiavel 
        Console.WriteLine("Insira a altura");
        altura = double.Parse(Console.ReadLine());
        imc = peso / (altura* altura);
        Console.WriteLine("IMC: "+ imc.ToString("f2") ); //Escreve o valor do IMC em forma de string

        //Os ifs são para informar se o peso e ideal ou não

        if (imc < 17)  
            Console.WriteLine("Peso muito abaixo do ideal");
     
        if (imc > 17 && imc <= 18.49)
            Console.WriteLine("Peso abaixo do ideal");

        if (imc > 18.49 && imc <= 24.99)
            Console.WriteLine("Peso ideal");

        if (imc > 24.99 && imc <= 29.99)
            Console.WriteLine("Sobrepeso");

        if (imc > 29.99 && imc <= 34.99)
            Console.WriteLine("Obesidade I");

        if (imc > 34.99 && imc <= 39.99)
            Console.WriteLine("Obesidade II");

        if (imc > 39.99)
            Console.WriteLine("Obsidade III");


        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();

    }




}







