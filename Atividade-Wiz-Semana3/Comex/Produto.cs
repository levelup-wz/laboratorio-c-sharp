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

        public string CalculaValorTotalEmEstoque()
        {
            return $"Valor total em estoque: R$ {Quantidade_Em_Estoque * Preco_Unitario}";
        }

        public string CalculaImposto()
        {
            return $"Valor de Imposto: R$ {Preco_Unitario * 0.40}";
        }
    }
}
