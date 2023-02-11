using System;
using System.ComponentModel.DataAnnotations;
using Comex.Modelos.Categorias;

namespace Comex.Modelos.Produtos;

public class Produto
{
    public Produto(string nome, decimal preco, int estoque, Categoria categoria)
    {
        if (nome.Length <= 3)
        {
            throw new ArgumentException("Nome deve ser maior que 3 caracteres", nameof(nome));
        }
        if (preco <= 0)
        {
            throw new ArgumentException("Preço obrigatório e não nulo", nameof(preco));
        }
        if (estoque <= 0)
        {
            throw new ArgumentException("Estoque obrigatório e não nulo", nameof(estoque));
        }
        if (categoria == null)
        {
            throw new ArgumentException("Categoria necessária", nameof(categoria));
        }

        Nome = nome;
        Preco = preco;
        Estoque = estoque;
        Categoria = categoria;
    }

    public Produto()
    {
    }

    public int Id { get; protected set; }
    public string Nome { get; }
    public decimal Preco { get; }
    public int Estoque { get; }
    public virtual Categoria Categoria { get; }
    public decimal ValorTotal => Preco * Estoque;
    public virtual decimal CalculaImposto => 0.1M * Preco;

    public int CategoriaId { get; set; }
}
