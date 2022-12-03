using System;
using System.Collections.Generic;
//using Comex.Pedido;
//using Comex.Produto;
//using Comex;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class Pedido
    {
        private int _Id;
        private DateTime _Data;
        private string _Cliente;
        private string _Produtos;
        private int _Quantidade;

        public int Id { get { return _Id; } set { _Id = value; } }
        public DateTime Data { get { return _Data; } set { _Data = value; } }

        public string Cliente { get { return _Cliente; } set { _Cliente = value; } }

        public string Produtos { get { return _Produtos; } set { _Produtos = value; } }

        public int Quantidade { get { return _Quantidade; } set { _Quantidade = value; } }

        public Pedido(int Id, string Clinete, string Produto, int Quantidade)
        {
            _Id = Id;
            _Cliente = Clinete;
            _Produtos = Produtos;
            _Quantidade = Quantidade;
        }

      /*  public double ValorPedido()
        {
            double ValorTotal = Quantidade * Produto._precoUnitario; // Está dando erro
            return ValorTotal;

 
        }*/

    }
}
/*public double CalculaValorTotal()
        {
            double resultado = Produto.Preco_Unitario * Quantidade_Vendida;
            return resultado;
        }

        public double CalculaTotalDeImpostos()
        {
            double resultado = Quantidade_Vendida * Produto.CalculaImposto();
            return resultado;*/
