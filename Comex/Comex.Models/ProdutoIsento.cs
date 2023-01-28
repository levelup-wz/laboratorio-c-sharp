using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class ProdutoIsento : Produto
    {
        public double CalcularImposto()
        {
            return 0;
        }

        public ProdutoIsento(string nome, double precoUnitario, int quantidade, Categoria categoria) :
        base (nome, precoUnitario, quantidade, categoria)
        {
        }
        public ProdutoIsento(int id, string nome, double precoUnitario, int quantidadeEmEstoque, Categoria produtoCategoria) : 
        base (id, nome, precoUnitario, quantidadeEmEstoque, produtoCategoria)
        {
        }
    }
}
