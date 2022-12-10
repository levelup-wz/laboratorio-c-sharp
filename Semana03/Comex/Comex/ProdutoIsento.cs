using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    internal class ProdutoIsento : Produto
    {
        public ProdutoIsento(string nome, double precoUnitario, int quantidade, string categoria) : base(nome, precoUnitario, quantidade, categoria)
        {

            Console.WriteLine("Criando um produto Isento");
        }

        public override double ValorEstoque()
        {
            return base.ValorEstoque();
        }

        public override double Imposto()
        {
            double TotalImposto = 0;
            return TotalImposto;
        }

        public string RetornaInfosProdutoIsento()
        {
            return $"ID produto número: {Id} \n " +
                $"Porduto: {Nome} \n" +
                $"Quantidade estoque: {Quantidade}\n" +
                $"Categoria: {Categoria}\n" +
                $"Valor unitário R$ {PrecoUnitario.ToString("N2")} \n" +
                $"Valor em estoque R$ {ValorEstoque().ToString("N2")}\n" +
                $"Valor imposto: {Imposto().ToString("N2")} \n";
        }

    }
}
