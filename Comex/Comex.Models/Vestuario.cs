using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class Vestuario : Produto
    {
        public string Tamanho { get; private set; }
        public string Cor { get; private set; }
        public Vestuario(string nome, double precoUnitario, int quantidade, Categoria categoria, string atributos) : base(nome, precoUnitario, quantidade, categoria)
        {
            Atributos = atributos;
        }
    }
}
