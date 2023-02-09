using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Entidades
{
    public class Produto
    {
        [Key]
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public double PrecoUnitario { get; set; }
        public int QuantidadeEstoque { get; private set; }
        public Categoria Categoria { get; set; }
        protected string? Atributo { get; set; }

        public Produto()
        {

        }

        public Produto(string nome, double precoUnitario, int quantidadeEstoque, Categoria categoria, string atributo)
        {
            Nome = nome;
            PrecoUnitario = precoUnitario;
            QuantidadeEstoque = quantidadeEstoque;
            Categoria = categoria;
            Atributo = atributo;
        }

        public Produto(string nome, double precoUnitario, int quantidadeEstoque, Categoria categoria)
        {
            Nome = nome;
            PrecoUnitario = precoUnitario;
            QuantidadeEstoque = quantidadeEstoque;
            Categoria = categoria;
        }

        public Produto(int id, string nome, double precoUnitario, int quantidadeEstoque, Categoria categoria)
        {
            try
            {
                ValidarInformacoes(id, nome, precoUnitario, quantidadeEstoque, categoria);
            }
            catch (ArgumentException error)
            {
                // Console.WriteLine(error.StackTrace);
                Console.WriteLine(error.Message);
                //throw;
            }
        }

        public double CalcularValorEstoque()
        {
            double valorEstoque = QuantidadeEstoque * PrecoUnitario;
            return valorEstoque;
        }

        public virtual double CalculaImposto()
        {
            double valorImposto = PrecoUnitario * 0.40;
            return valorImposto;
        }

        public string ListarProdutos()
        {
            return ($"Id: {Id} - Produto: {Nome} - Preço Unitário: R$ {PrecoUnitario.ToString("n2")}\n" +
                $"Quantidade em Estoque: {QuantidadeEstoque} - Categoria: {Categoria.Nome}\n" +
                $"Valor total em Estoque: {CalcularValorEstoque().ToString("n2")} - Imposto: {CalculaImposto().ToString("n2")}\n");
        }

        public void ValidarInformacoes(int id, string nome, double precoUnitario, int quantidadeEstoque, Categoria categoria)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Campo ID deve ser maior que ZERO");
            }
            if (nome.Length <= 5)
            {
                throw new ArgumentException("Campo NOME deve ter mais de 5 caracteres");
            }
            if (precoUnitario <= 0)
            {
                throw new ArgumentException("Campo PREÇO UNITÁRIO deve ser maior que ZERO");
            }
            if (quantidadeEstoque <= 0)
            {
                throw new ArgumentException("Campo QUANTIDADE EM ESTOQUE deve ser maior que ZERO");
            }
            else
            {
                Id = id;
                Nome = nome;
                PrecoUnitario = precoUnitario;
                QuantidadeEstoque = quantidadeEstoque;
                Categoria = categoria;

                Console.WriteLine($"Produto: {Nome} criado com sucesso!");
            }
        }

    }
}
