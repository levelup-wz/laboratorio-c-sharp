using Comex.Entity;
using NumericWordsConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscritaPorExtenso.Moeda;


namespace Comex.Models.Entity
{
    public class Invoice
    {
        internal Order Order { get; set; }
        public string ExtensiveValue { get; set; }
        public string ExtensiveValuePT { get; set; }

        public Invoice(Order order)
        {
            Order = order;
            NumericWordsConverter converter = new NumericWordsConverter();
            ExtensiveValue = converter.ToWords((decimal)order.TotalPrice());
            ExtensiveValuePT = order.TotalPrice().PorExtensoDeReal();
        }

        public string GetInvoice()
        {
            return $"Cliente: {Order.Client.GetFullName()} \n " +
                $"Valor total: R${Order.TotalPrice()} \n " +
                $"Valor por extenso pt: {ExtensiveValuePT}  \n " +
                $"Valor por extenso en: {ExtensiveValue}  \n " +
                $"Data: {Order.Date}";


        }
    }
}