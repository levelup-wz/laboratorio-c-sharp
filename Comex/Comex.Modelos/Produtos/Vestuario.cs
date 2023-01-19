using Comex.Modelos.Categorias;
using System;

namespace Comex.Modelos.Produtos
{
    public class Vestuario : Produto
    {
        public string Tamanho { get; }
        public string Cor { get; }

        public Vestuario(string nome, string descricao, double preco, int estoque, Categoria categoria, string atributos)
            : base(nome, descricao, preco, estoque, categoria)
        {
            Atributos = atributos;

            Tamanho = Extrator("tamanho:", atributos);
            Cor = Extrator("cor:", atributos);
        }

        private string Extrator(string param, string arg)
        {
            param = param.ToLower();
            int index = arg.IndexOf(param);

            string resultado = arg.Substring(index + param.Length);

            if (resultado.IndexOf(';') == -1)
            {
                return resultado;
            }

            return resultado.Remove(resultado.IndexOf(';'));
        }
    }
}
