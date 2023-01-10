using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comex.Models;

namespace Comex.TestaModels
{
    public class TestaProduto
    {
        Produto produto1 = new Produto("Notebook Samsung", 3523.00, 1, "Informática");
        Produto produto2 = new Produto("Clean Architecture", 102.90, 2, "Livros");
        Produto produto3 = new Produto("Monitor Dell 27", 1889.00, 3, "Informática");

        public TestaProduto()
        {
            Console.WriteLine($"{produto1.InformacoesDoProduto()} Valor total do produto em estoque:{produto1.ValorTotalEmEstoque():C2}\n Imposto Unidade:{produto1.CalculaImposto():C2}\n");
            Console.WriteLine($"{produto2.InformacoesDoProduto()} Valor total do produto em estoque:{produto2.ValorTotalEmEstoque():C2}\n Imposto Unidade:{produto2.CalculaImposto():C2}\n");
            Console.WriteLine($"{produto3.InformacoesDoProduto()} Valor total do produto em estoque:{produto3.ValorTotalEmEstoque():C2}\n Imposto Unidade:{produto3.CalculaImposto():C2}\n");
        }
    }
}
