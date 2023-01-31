using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models.Extensoes
{
    public static class ProdutosExtensao
    {
        public static Produto EncontrarPeloNome(this List<Produto> lista, string nome)
        {
            var produto = lista .FirstOrDefault(p => p.Nome.ToLower() == nome.ToLower());
            return produto;

        }     
        
    }
}
