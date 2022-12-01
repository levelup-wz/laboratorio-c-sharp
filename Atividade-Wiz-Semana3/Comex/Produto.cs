using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descircao { get; set; }
        public double Preco_Unitario { get; set; }
        public double Quantidade_Em_Estoque { get; set; }
        public string Categoria { get; set; }

        public Produto (int id, string nome, double preco_Unitario, double quantidade_Em_Estoque, string categoria)
        {
            Id = id;
            Nome = nome;
            Preco_Unitario = preco_Unitario;
            Quantidade_Em_Estoque = quantidade_Em_Estoque;
            Categoria = categoria;
        }

        public double CalculaValorTotalEmEstoque()
        {
            double resultado = Quantidade_Em_Estoque * Preco_Unitario;
            return resultado;
        }

        public double CalculaImposto()
        {
            double resultado = Preco_Unitario * 0.40;
            return resultado;
        }
    }
}
