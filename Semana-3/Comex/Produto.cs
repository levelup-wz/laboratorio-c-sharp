using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double PrecoUnitario { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        public string Categoria { get; set; }

        public Produto(int id, string nome, double precoUnitario, int quantidadeEmEstoque, string categoria)
        {
            Id = id;
            Nome = nome;
            PrecoUnitario = precoUnitario;
            QuantidadeEmEstoque = quantidadeEmEstoque;
            Categoria = categoria;
        }

        public string InformacoesDoProduto()
        {
            return $" Id: {Id}\n Nome: {Nome}\n Preço Unitário: {PrecoUnitario:C2}\n Quantidade em Estoque: {QuantidadeEmEstoque}\n Categoria: {Categoria}\n";
        }

        public double ValorTotalEmEstoque()
        {
           return QuantidadeEmEstoque * PrecoUnitario;
        }

        public double CalculaImposto()
        {
            return PrecoUnitario * 0.40;
        }

    }
}
