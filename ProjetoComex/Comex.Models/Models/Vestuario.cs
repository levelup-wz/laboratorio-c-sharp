using Comex.Entidades;
using Comex.Models.Extensoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models.Models
{
    public class Vestuario : Produto
    {
        public string Tamanho { get; }
        public string Cor { get; }
        public Vestuario(string nome, double precoUnitario, int quantidadeEstoque, Categoria categoria, string atributos) : base(nome, precoUnitario, quantidadeEstoque, categoria, atributos)
        {
            Tamanho = atributos.ExtrairTamanho();
            Cor = atributos.ExtrairCor();
        }

    }
}
