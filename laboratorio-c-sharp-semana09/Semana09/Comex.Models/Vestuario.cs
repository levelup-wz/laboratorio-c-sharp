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

        public Vestuario(string nome, double precoUnitario, int quantidade, string categoria, string atributos) : base (nome, precoUnitario, quantidade, categoria, atributos)
        {
            Tamanho = Atributos.ExtrairTamanho();
            Cor = Atributos.ExtrairCor();

        }
    }
}
