using Comex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Testes
{
    public class TesteCPF
    {
        static CPF cpf1 = new("11133344455");
        static CPF cpf2 = new("22233344455");
        static CPF cpf3 = new("33344455566");
        static CPF cpf4 = new("abcdefghijk");
        static CPF cpf5 = new("");
        static CPF cpf6 = new("123456789987456321");
        static CPF cpf7 = new("12345");

        public static void RetornaCpf()
        {
            try
            {
                Console.WriteLine($"Entrada de CPF: {cpf1}");
                Console.WriteLine($"Retorno CPF Formatado: {cpf1.Formatar()}" + "\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine($"{ex.Message} \n");
            }
            try
            {
                Console.WriteLine($"Entrada de CPF: {cpf2}");
                Console.WriteLine($"Retorno CPF Formatado: {cpf2.Formatar()}" + "\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine($"{ex.Message} \n");
            }
            try
            {
                Console.WriteLine($"Entrada de CPF: {cpf3}");
                Console.WriteLine($"Retorno CPF Formatado: {cpf3.Formatar()}" + "\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine($"{ex.Message} \n");
            }
            try
            {
                Console.WriteLine($"Entrada de CPF: {cpf4}");
                Console.WriteLine($"Retorno CPF Formatado: {cpf4.Formatar()}" + "\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine($"{ex.Message} \n");
            }
            try
            {
                Console.WriteLine($"Entrada de CPF: {cpf5}");
                Console.WriteLine($"Retorno CPF Formatado: {cpf5.Formatar()}" + "\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine($"{ex.Message} \n");
            }
            try
            {
                Console.WriteLine($"Entrada de CPF: {cpf6}");
                Console.WriteLine($"Retorno CPF Formatado: {cpf6.Formatar()}" + "\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine($"{ex.Message} \n");
            }
            try
            {
                Console.WriteLine($"Entrada de CPF: {cpf7}");
                Console.WriteLine($"Retorno CPF Formatado: {cpf7.Formatar()}" + "\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine($"{ex.Message} \n");
            }

            //Console.WriteLine($"Entrada de CPF: {cpf2}");
            //Console.WriteLine($"Retorno CPF Formatado: {cpf2.Formatar()}" + "\n");
            //Console.WriteLine($"Entrada de CPF: {cpf3}");
            //Console.WriteLine($"Retorno CPF Formatado: {cpf3.Formatar()}" + "\n");
            //Console.WriteLine($"Entrada de CPF: {cpf4}");
            //Console.WriteLine($"Retorno CPF Formatado: {cpf4.Formatar()}" + "\n");
            //Console.WriteLine($"Entrada de CPF: {cpf5}");
            //Console.WriteLine($"Retorno CPF Formatado: {cpf5.Formatar()}" + "\n");
            //Console.WriteLine($"Entrada de CPF: {cpf6}");
            //Console.WriteLine($"Retorno CPF Formatado: {cpf6.Formatar()}" + "\n");
        }
    }
}
