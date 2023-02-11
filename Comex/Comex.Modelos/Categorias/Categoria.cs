using Comex.Modelos.Produtos;
using System;

namespace Comex.Modelos.Categorias;

public class Categoria
{
    /// <summary>
    /// Cria uma categoria nova
    /// </summary>
    /// <param name="nome"> <see cref="Nome"/> da categoria necessário e maior que 3 caracteres </param>
    /// <param name="status"> <see cref="Status"/> (ATIVA / INATIVA) </param>
    /// <exception cref="ArgumentException"></exception>
    public Categoria(string nome, string status)
    {
        if (nome.Length <= 3)
        {
            throw new ArgumentException("Nome deve ser maior que 3 caracteres", nameof(nome));
        }
        if (status != "ATIVA" && status != "INATIVA")
        {
            throw new ArgumentException("Status deve ser somente ATIVA ou INATIVA", nameof(status));
        }

        Nome = nome;
        Status = status;
    }

    public int Id { get; }
    public string Nome { get; }
    public string Status { get; }

    public List<Produto> Produtos { get; set; }
}
