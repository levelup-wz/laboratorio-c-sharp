//using Comex;
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
        public int Quantidade { get; set; }
        public string Categoria { get; set; }
        public Produto produto { get; set; }

        public Produto(int id, string nome, double precoUnitario, int quantidade, string categoria)
        {
            Id = id;
            Nome = nome;
            PrecoUnitario= precoUnitario;
            Quantidade = quantidade;
            Categoria = categoria;

        }

        public double ValorEstoque()
        {
            double total = PrecoUnitario * Quantidade;
            return total;
        }

        public double Imposto()
        {
            double TotalImposto = PrecoUnitario * 0.40;
            return TotalImposto;
        }

    }
}
