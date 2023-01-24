using Comex.Entidades;
using Comex.Models.Models;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Testes
{
    public class TestVestuario
    {
        
        [Theory]
        [InlineData("Vestido", 120.00, 10, "vestuario", "tamanho: M; cor: Rosa", "M", "Rosa")]
        [InlineData("Vestido", 120.00, 10, "vestuario", "tamanho: P; cor: Vermelho", "P", "Vermelho")]
        [InlineData("Vestido", 120.00, 10, "vestuario", "tamanho: G; cor: Amarelo", "G", "Amarelo")]
        public void TestCreateNewVestuario(string nameEntry, double priceEntry, int quantity, string categoria, string atributesEntry, string grade, string color)
        {
            var vestuario = new Categoria(categoria);
            var vestido = new Vestuario(nameEntry, priceEntry, quantity, vestuario, atributesEntry);

            vestido.Tamanho.Should().Be(grade);
            vestido.Cor.Should().Be(color);
        }

        
    }
}
