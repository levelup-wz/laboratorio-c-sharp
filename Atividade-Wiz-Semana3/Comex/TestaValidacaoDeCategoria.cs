using Comex.Models;

namespace Comex
{
    public class TestaValidacaoDeCategoria
    {
        public static void RegistaEntradaParametro()
        {
            try
            {
                Categoria teste1 = new(0, "INFORMÁTICA", "ATIVA");
             
                Console.WriteLine($"{teste1.Nome} ({teste1.Id} - {teste1.Status})");
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
                Categoria teste2 = new(20, "MÓV", "INATIVA");

                Console.WriteLine($"{teste2.Nome} ({teste2.Id} - {teste2.Status})");
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
                Categoria teste3 = new(25, "LIVROS", "ERRO");

                Console.WriteLine($"{teste3.Nome} ({teste3.Id} - {teste3.Status})");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }
    }
}
