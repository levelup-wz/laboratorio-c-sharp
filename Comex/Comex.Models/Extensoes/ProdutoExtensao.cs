using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comex.Models;

namespace Comex.Models.Extensoes
{
    public static class ProdutoExtensao
    {
        public static Produto EncontrarPeloNome(this List<Produto> produtos, string nome)
        {
            foreach (var produto in produtos)
            {
                bool nomeEncontrado = produto.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase);
                if (nomeEncontrado) return produto;
            }

            return default;
        }
    }
}
