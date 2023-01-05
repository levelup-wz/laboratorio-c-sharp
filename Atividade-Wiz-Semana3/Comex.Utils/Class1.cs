namespace Comex.Utils
{
    public class Correios
    {
        public static void ObterRegiaoPorCEP (string CEP)
        {
            if (CEP[0] == 0)
            {
                Console.WriteLine("Região 0 = Sede São Paulo");
            }
            if (CEP[0] == 1)
            {
                Console.WriteLine("Região 1 = Sede Santos");
            }
            if (CEP[0] == 2)
            {
                Console.WriteLine("Região 2 = Sede Rio de Janeiro");
            }
            if (CEP[0] == 3)
            {
                Console.WriteLine("Região 3 = Sede Belo Horizonte");
            }
            if (CEP[0] == 4)
            {
                Console.WriteLine("Região 4 = Sede Salvador");
            }
            if (CEP[0] == 5)
            {
                Console.WriteLine("Região 5 = Sede Recife");
            }
            if (CEP[0] == 6)
            {
                Console.WriteLine("Região 6 = Sede Fortaleza");
            }
            if (CEP[0] == 7)
            {
                Console.WriteLine("Região 7 = Sede Brasilia");
            }
            if (CEP[0] == 8)
            {
                Console.WriteLine("Região 8 = Sede Curitiba");
            }
            if (CEP[0] == 9)
            {
                Console.WriteLine("Região 9 = Sede Proto Alegre");
            }
            else
            {
                Console.WriteLine("Sede não encontrada.");
            }
        }
    }
}