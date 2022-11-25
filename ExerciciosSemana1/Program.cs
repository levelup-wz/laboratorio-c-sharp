using ExerciciosSemana1.ExerciciosSemana1;

Console.WriteLine("Hello, World! \n");
static void ExercicioSemanaUm()
{
    Console.WriteLine("Exercicios Semana 1");
    string opcao = "0";
    while (opcao != "11")
{   
    Console.WriteLine("1 - Calcular Média e aprovação da turma");
    Console.WriteLine("2 - Verificar Números Ímpares de 1 a 100 com laço FOR");
    Console.WriteLine("3 - Verificar Números Ímpares de 1 a 100 com laço WHILE");
    Console.WriteLine("4 - Somar números de 1 a 100 com laço FOR");
    Console.WriteLine("5 - Somar números de 1 a 100 com laço WHILE");
    Console.WriteLine("6 - Calcular o vigésimo elemento da Sequência Fibonacci com 3 variáveis");
    Console.WriteLine("7 - Calcular o vigésimo elemento da Sequência Fibonacci com 2 variáveis");
    Console.WriteLine("8 - Cadastrar Cliente");
    Console.WriteLine("9 - Calcular equação 2 grau");
    Console.WriteLine("10 - Calcular IMC");
    Console.WriteLine("11 - Sair");
    Console.Write("Escolha o Exercicio a ser demonstrado: ");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            CalcularMediaNota.Calcular();
            break;
        case "2":
            VerificarNumerosImpares.CalcularFor();
            break;
        case "3":
            VerificarNumerosImpares.CalcularWhile();
            break;
        case "4":
            SomarUmACem.CalcularFor();
            break;
        case "5":
            SomarUmACem.CalcularWhile();
            break;
        case "6":
            Fibonacci.CalcularFibonacciComWhile();
            break;
        case "7":
            Fibonacci.CalcularFibonacciComForDuasVariaveis();
            break;
        case "8":
            CadastrarCliente.Cadastrar();
            break;
        case "9":
            EquacaoSegundoGrau.Calcular();
            break;
        case "10":
            CalculadoraImc.Calcular();
            break;
        case "11":
            Console.WriteLine("\nObrigado! Volte Sempre!\n"); ;
            break;
        default:
            Console.WriteLine("Opção Inválida");
            Console.Clear();
            break;
    }
}
}

ExercicioSemanaUm();
