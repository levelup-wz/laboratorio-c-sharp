using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double PrecoUnitario { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        public string Categoria { get; set; }
        protected string Atributos { get; set; }

        public Produto() { }

        public Produto(string nome, double precoUnitario, int quantidadeEmEstoque, string categoria)
        {
            validaEntradaDeDados(nome, precoUnitario, quantidadeEmEstoque, categoria);
        }

        public Produto(string nome, double precoUnitario, int quantidadeEmEstoque, string categoria, string atributos)
        {
            Atributos = atributos;
            validaEntradaDeDados(nome, precoUnitario, quantidadeEmEstoque, categoria);
        }

        public string InformacoesDoProduto()
        {
            return $" Id: {Id}\n Nome: {Nome}\n Preço Unitário: {PrecoUnitario:C2}\n Quantidade em Estoque: {QuantidadeEmEstoque}\n Categoria: {Categoria}\n";
        }

        public virtual double ValorTotalEmEstoque()
        {
           return QuantidadeEmEstoque * PrecoUnitario; 
        }

        public virtual double CalculaImposto()
        {
            return PrecoUnitario * 0.40;
        }

        public void validaEntradaDeDados(string nome, double precoUnitario, int quantidadeEmEstoque, string categoria)
        {
            if(nome.Length < 5 )
            {
                throw new ArgumentException("O nome deve ser maior que 5 caracteres", nameof(nome));
            }
            if(precoUnitario <= 0)
            {
                throw new ArgumentException("O preço unitário deve ser maior que 0", nameof(precoUnitario));
            }
            if(quantidadeEmEstoque <= 0)
            {
                throw new ArgumentException("A quantidade em estoque deve ser maior que 0", nameof(quantidadeEmEstoque));

            }
            if (String.IsNullOrEmpty(categoria))
            {
                throw new ArgumentException("A categoria deve ser informada", nameof(categoria));
            }
            Nome = nome;
            PrecoUnitario = precoUnitario;
            QuantidadeEmEstoque = quantidadeEmEstoque;
            Categoria = categoria;
        }
    }
}
