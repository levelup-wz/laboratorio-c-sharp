using Comex;
using Comex.Models.Extensoes;
using Comex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.TestesUnitarios
{
    public class ProdutosExtensaoTeste
    {
        [Fact]
        public void Deve_encontrar_um_produto_na_lista_pela_descricao()
        {
            List<Produto> produtos = new();
            var camisa = new Produto("Camisa", 10, 10, categoria: "Roupas","vermelha");
            var tenis = new Produto("Tenis", 20, 20, categoria: "Roupas","preto");
            produtos.AddRange(new[] { camisa, tenis });

            Assert.True(produtos.EncontrarPeloNome("Camisa").Nome.Equals("Camisa"));
            Assert.True(produtos.EncontrarPeloNome("camisa").Nome.Equals("Camisa"));
            Assert.True(produtos.EncontrarPeloNome("Tenis").Nome.Equals("Tenis"));
            Assert.True(produtos.EncontrarPeloNome("tenis").Nome.Equals("Tenis"));
        }

    }
}

