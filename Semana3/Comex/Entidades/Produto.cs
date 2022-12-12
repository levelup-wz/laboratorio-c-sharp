using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Entidades
{
    public class Produto
    {
        public static int prodId = 1;
        public int _id { get; private set; }
        public string _nome { get; set; }
        public string _descricao { get; set; }
        public double _precoUnitario { get; set; }
        public int _quantidadeEstoque { get; set; }
        public Categoria _categoria { get; set; }

        public Produto(string nome, double precoUnitario, int quantidadeEstoque, Categoria categoria)
        {
            _nome = nome;
            _precoUnitario = precoUnitario;
            _quantidadeEstoque = quantidadeEstoque;
            _categoria = categoria;
            _id = Produto.prodId;
            Produto.prodId++;
        }

        public Produto(int id, string nome, double precoUnitario, int quantidadeEstoque, Categoria categoria)
        {
            try
            {
                ValidarInformacoes(id, nome, precoUnitario, quantidadeEstoque, categoria);
            }
            catch (ArgumentException erro)
            {
                Console.WriteLine(erro.Message);
            }
        }

        public double CalcularValorEstoque()
        {
            double valorEstoque = _quantidadeEstoque * _precoUnitario;
            return valorEstoque;
        }

        public virtual double CalculaImposto()
        {
            double valorImposto = _precoUnitario * 0.40;
            return valorImposto;
        }

        public string ListarProdutos()
        {
            return ($"Id: {_id} - Produto: {_nome} - Preço Unitário: R$ {_precoUnitario.ToString("n2")}\n" +
                $"Quantidade em Estoque: {_quantidadeEstoque} - Categoria: {_categoria.Nome}\n" +
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
                _id = id;
                _nome = nome;
                _precoUnitario = precoUnitario;
                _quantidadeEstoque = quantidadeEstoque;
                _categoria = categoria;

                Console.WriteLine($"Produto: {_nome} criado com sucesso!");
            }
        }

    }
}
