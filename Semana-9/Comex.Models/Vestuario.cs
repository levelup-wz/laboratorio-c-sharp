using Comex.Models.Extensoes;

namespace Comex.Models
{
    public class Vestuario : Produto
    {
        public readonly string Tamanho;
        public readonly string Cor;
        public Vestuario(string nome, double precoUnitario, int quantidadeEmEstoque, string categoria, string atributos) : base(nome, precoUnitario, quantidadeEmEstoque, categoria, atributos)
        {
            Tamanho = atributos.ExtrairTamanho();
            Cor = atributos.ExtrairCor();
        }
    }
}
