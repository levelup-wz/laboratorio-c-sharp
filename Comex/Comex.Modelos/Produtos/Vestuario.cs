using Comex.Modelos.Categorias;
using Comex.Modelos.Extensions;
using System;

namespace Comex.Modelos.Produtos;

public class Vestuario : Produto
{
    public Vestuario(string nome, decimal preco, int estoque, Categoria categoria, string atributos)
    : base(nome, preco, estoque, categoria)
    {
        Atributos = atributos;

        Tamanho = this.ExtrairTamanho(atributos);
        Cor = this.ExtrairCor(atributos);
    }

    public static new int Quantidade { get; private set; }
    public string Atributos { get; set; }
    public string Tamanho { get; }
    public string Cor { get; }
}
