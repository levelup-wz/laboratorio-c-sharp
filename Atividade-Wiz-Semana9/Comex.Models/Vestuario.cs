using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comex.Models.Extensoes;

namespace Comex.Models
{
    public class Vestuario : Produto
    {
        public string Tamanho { get; }
        public string Cor { get; }


        public Vestuario(string nome, decimal precoUnitario, int quantidadeEmEstoque, string categoria, string atributos) : base(nome, precoUnitario, quantidadeEmEstoque, categoria, atributos)
        {
            Tamanho = atributos.ExtrairTamanho();
            Cor = atributos.ExtrairCor();
        }
    }
}
