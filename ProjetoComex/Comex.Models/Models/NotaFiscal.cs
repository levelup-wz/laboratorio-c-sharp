using Comex.Entidades;
using EscritaPorExtenso.Moeda;
using NumericWordsConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models.Models
{
    public class NotaFiscal
    {
        internal Pedido Pedido { get; set; }
        string Words { get; set; }
        string WordsPortuguese { get; set; }

        public NotaFiscal(Pedido pedido)
        {
            if (pedido == null)
            {
                throw new ArgumentNullException("Precisa passar um pedido válido como parâmetro");
            }
            Pedido = pedido;
            CurrencyWordsConverter converter = new CurrencyWordsConverter();
            Words = converter.ToWords((decimal)Pedido.CalcularValorTotal());
            WordsPortuguese = Pedido.CalcularValorTotal().PorExtensoDeReal();
        }

        public override string ToString()
        {
            return
                $"Numero pedido: {Pedido.Id}\n" +
                $"Nome: {Pedido.Cliente.Nome} {Pedido.Cliente.SobreNome}\n" +
                $"Data da compra: {Pedido.Date}\n" +
                $"Total do pedido: R$ {Pedido.CalcularValorTotal().ToString("n2")} => " +
                $"{Words}\n" +
                $"{WordsPortuguese}";
        }
    }
}
