using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOO.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public float PrecoUnitario { get; set; }

        public int Quantidade { get; set; }

        public Categoria Categoria { get; set; }

        public float CalcularTotalEstoque()
        {
            return this.Quantidade * this.PrecoUnitario;
        }

        public float CalcularImposto()
        {
            return this.PrecoUnitario * 0.4F;
        }

        public override string ToString()
        {
            return "id " + Id + " nome " + Nome  + ", preço unitário " + PrecoUnitario +
                ", quantidade em estoque " + Quantidade + ", categoria " + Categoria +
                ", Valor total " + CalcularTotalEstoque() + ", Imposto " + CalcularImposto();
        }
    }
}
