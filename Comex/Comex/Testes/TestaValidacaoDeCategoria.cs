/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comex;

namespace Comex.Testes
{
    public class TestaValidacaoDeCategoria
    {
        try
        {
            Categoria saude = new Categoria(0, "Ana", "INDEFINIDO");
            }
        catch (ArgumentException e)
        {
            Console.WriteLine($"ERRO: {e.Message}");
        }
    }
}*/