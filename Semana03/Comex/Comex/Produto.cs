using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex

{
    public class Produto
    {
        private int _id;
        private string _nome;
        private string _descricao;
        private double _precoUnitario;
        private int _quantidade;
        private string _categoria;

        public int Id { get { return _id; } set { Id = value; } }
        public string Nome { get { return _nome; } set { _nome = value; } }

        public string Descricao { get { return _descricao; } set { _descricao = value; } }

        public double PrecoUnitario { get { return _precoUnitario; } set { _precoUnitario = value; } }

        public int Quantidade { get { return _quantidade; } set { _quantidade = value; } }

        public string Categoria { get { return _categoria; } set { _categoria = value; } }

        public Produto(int Id, string Nome, double PrecoUnitario, int Quantidade, string Categoria)
        {


           /* Id = id;
            Nome = nome;
            PrecoUnitario = precoUnitario;
            Quantidade = quantidade;
            Categoria = categoria;*/

            _id = Id;
            _nome = Nome;
            _precoUnitario = PrecoUnitario;
            _quantidade = Quantidade;
            _categoria = Categoria;

        }

        public double ValorEstoque()
        {
            double total = PrecoUnitario * Quantidade;
            return total;
        }

        public double Imposto()
        {
            double TotalImposto = PrecoUnitario * 0.40;
            return TotalImposto;
        }

    }
}
