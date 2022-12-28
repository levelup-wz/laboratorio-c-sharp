using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumericWordsConversion;
using EscritaPorExtenso.Moeda;



namespace Comex.Models
{
    public class NotaFiscal
    {
        internal Pedido Pedido { get; set;}
        public string ValorExtensoIngles { get; set; }
        public string ValorExtensoPortugues { get; set; }

        


        public NotaFiscal(Pedido pedido)
        {
            Pedido = pedido;
            NumericWordsConverter converter = new NumericWordsConverter();
            ValorExtensoIngles = converter.ToWords((decimal)pedido.ValorPedido());
            ValorExtensoPortugues = Pedido.ValorPedido().PorExtensoDeReal();
           

        }

        public override string ToString()
        {
            return $" Nome completo:{Pedido.ClientePedido.Nome} {Pedido.ClientePedido.Sobrenome} \n" +
                $"Data da Compra: {Pedido.Data} \n" +
                $"Total do Pedido: {Pedido.ValorPedido()} \n" +
                $"Valor Total do Pedido por Extenso em Inglês: {ValorExtensoIngles} \n" +
                $"Valor Total do Pedido por Extenso em Português: {ValorExtensoPortugues}";
        }
    }
}
