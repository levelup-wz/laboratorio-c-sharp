
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex

{
    public class Produto
    {
        private static int _id = 0;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
        public string Categoria { get; set; }
        public Produto produto { get; set; } //tipo produto

        protected String Atributos { get; set; }

        public Produto( string nome, double precoUnitario, int quantidade, string categoria, string atributos)
        {
            Id = ++_id;
            Nome = nome;
            PrecoUnitario= precoUnitario;
            Quantidade = quantidade;
            Categoria = categoria;
            Atributos = atributos;

            if (nome.Length < 5)
            {
                throw new ArgumentException("O nome deve conter mais de cinco caracteres", nameof(nome));
            }
            if (precoUnitario <= 0)
            {
                throw new ArgumentException("O preço unitário de um produto deve ser maior que zero", nameof(precoUnitario));
            }
            if (quantidade <= 0)
            {
                throw new ArgumentException("A quantidade de produto em estoque deve ser maior do que zero", nameof(quantidade));
            }
            if (categoria == null)
            {
                throw new ArgumentException("A categoria do produto deve ser informada", nameof(categoria));
            }
            else
            {
                RetornaInfosProduto();
            }

        }

        public virtual double ValorEstoque()
        {
            double total = PrecoUnitario * Quantidade;
            return total;
        }

        public virtual double Imposto()
        {
            double TotalImposto = PrecoUnitario * 0.40;
            return TotalImposto;
           
        }

        public string RetornaInfosProduto()
        {
            return $"ID produto número: {Id} \n " +
                $"Porduto: {Nome} \n" +
                $"Quantidade estoque: {Quantidade}\n" +
                $"Categoria: {Categoria}\n" +
                $"Valor unitário R$ {PrecoUnitario.ToString("N2")} \n" +
                $"Valor em estoque R$ {ValorEstoque().ToString("N2")}\n" +
                $"Valor imposto: {Imposto().ToString("N2")} \n";
        }

      /*  public void ValidacaoDeProdutos(string nome, double precoUnitario, int quantidade, string categoria)
        {
            Nome = nome;
            PrecoUnitario = precoUnitario;
            Quantidade = quantidade;
            Categoria = categoria;

            if (nome.Length <= 5)
            {
                throw new ArgumentException("O nome deve conter mais de cinco caracteres", nameof(nome));
            }
            if (precoUnitario <= 0)
            {
                throw new ArgumentException("O preço unitário de um produto deve ser maior que zero", nameof(precoUnitario));
            }
            if(quantidade <= 0)
            {
                throw new ArgumentException("A quantidade de produto em estoque deve ser maior do que zero", nameof(quantidade));
            }
            if (categoria == null)
            {
                throw new ArgumentException("A categoria do produto deve ser informada", nameof(categoria));
            }
            else
            {
                RetornaInfosProduto();
            }*/

            


        }
 }

