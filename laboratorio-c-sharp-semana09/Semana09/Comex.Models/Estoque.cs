using Comex;
using Comex.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comex.Models;

namespace Comex.Models
{
    public class Estoque
    {
        //private object error;

        public int Capacidade { get; private set; } = 1000;
        public int Ocupacao { get; private set; } 
         public decimal Montante { get; private set; }
        public Produto Produto { get; set; }

        

        public void RegistarEntrada(Produto produto)
        {
            if (produto.Quantidade > Capacidade)
            {
                throw new Exceptions.LimiteDeEstoqueExcedidoException("O estoque não tem capacidade para essa quantidade de produtos!");
                
            }
            if(Ocupacao >= 1000)
            {
                throw new LimiteDeEstoqueExcedidoException("Ocupação excedida");
            }
            else
            {
                Capacidade -= produto.Quantidade;
                Ocupacao += produto.Quantidade;
                Montante += Convert.ToDecimal(produto.ValorEstoque());


            }



            /* Capacidade -= produto.Quantidade;
             Ocupacao += produto.Quantidade;
             Montante += Convert.ToDecimal(produto.ValorEstoque());*/
        }

        public void RegistarSaida(Produto produto)
        {
            if (Ocupacao<=0) 
            {
                throw new LimiteDeEstoqueExcedidoException("O estoque está vazio");
            }
            else
            {
                Capacidade += produto.Quantidade;
                Ocupacao -= produto.Quantidade;
                Montante -= Convert.ToDecimal(produto.ValorEstoque());
            }
           
        }

        public string RetornarInfosEstoque()
        {

            return $"Capacidade {Capacidade} \n " +
                $"Ocupação {Ocupacao} \n" +
                $"Montante {Montante} \n";

        }

    }

       

        

    
}



  

