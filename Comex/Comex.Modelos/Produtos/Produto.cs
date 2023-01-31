using System;
using System.ComponentModel.DataAnnotations;
using Comex.Modelos.Categorias;

namespace Comex.Modelos.Produtos;

public class Produto
{
    public static int Quantidade { get; private set; }

    [Key]
    public int Id { get; protected set; }
    public string Nome { get; }
    public decimal Preco { get; }
    public int Estoque { get; }
    public Categoria Categoria { get; }

    public decimal ValorTotal()
    {
        return Preco * Estoque;
    }

    public virtual decimal CalculaImposto()
    {
        return 0.4M * Preco;
    }

    /// <summary>
    /// Cria uma instância de Produto
    /// </summary>
    /// <param name="nome"> <see cref="Nome"/> necessário e maior que 5 caracteres </param>
    /// <param name="preco"> <see cref="Preco"/> obrigatório e diferente de zero </param>
    /// <param name="estoque"> <see cref="Estoque"/> obrigatório e diferente de zero </param>
    /// <param name="categoria"> <see cref="Categoria"/> obrigatória </param>
    /// <exception cref="ArgumentException"></exception>
    public Produto(string nome, decimal preco, int estoque, Categoria categoria)
    {
        Quantidade++;
        Id = Quantidade;

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

    public override string ToString()
    {
        return $"[{Id}] - {Nome} R${ Preco} \nCategoria: {Categoria.Nome}" +
            $"\nQuantidade em estoque: {Estoque} \nImposto R${CalculaImposto()}";
    }
}
