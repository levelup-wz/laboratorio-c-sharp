using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSemana1.ExerciciosSemana1
{
    public class CadastrarCliente
    {   
        public static void Cadastrar()
        {   
            Console.Clear();
            Console.WriteLine("\n**********************************");
            Console.WriteLine("Bem vindo ao LevelUp - Wiz - Alura");
            Console.WriteLine("****** Cadastro de Clientes ******\n");
            Console.Write("Digite nome do Cliente: ");
            string nomeCliente = Console.ReadLine();
            Console.Write("Digite o email do Cliente: ");
            string emailCliente = Console.ReadLine();
            Console.WriteLine($"\nOlá, {nomeCliente}! Usuário {emailCliente} cadastrado!");
            Console.WriteLine("\n**********************************\n");
        }
    }
}
