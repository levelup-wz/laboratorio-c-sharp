using Comex.Models;
using Comex.Models.Lib;

using FluentAssertions;

using Xunit;

namespace Comex.Testes
{
    public class ProdutoGenericoTest
    {


        [Fact]
        public void Deve_instanciar_classe_com_decimal()
        {
            var camisas = new Produto<decimal>("Fibra Otica", 12, 2, "Info");
            Assert.Equal(24, camisas.ValorTotalEmEstoque());
        }

        [Fact]
        public void Deve_instanciar_classe_com_inteiro()
        {
            var camisas = new Produto<int>("Fibra Otica", 20, 2, "Info");
            Assert.Equal(40, camisas.ValorTotalEmEstoque());
        }

        [Fact]
        public void Deve_calcular_o_total_com_tipos_diferentes()
        {
            //var cabo = new Produto<decimal>("Fibra Otica", 12.3, 2.5m,"Info");
            var camisas = new Produto<float>("Fibra Otica", 30, 2, "Info");
            var camisas1 = new Produto<double>("Fibra Otica", 20, 20, "Info");

            Assert.Equal(60, camisas.ValorTotalEmEstoque());
            Assert.Equal(400, camisas1.ValorTotalEmEstoque());
        }

        [Theory]
        [InlineData(0)]
        public void Deve_estourar_exception_se_o_quantidade_for_zero_ou_negativo(int quantidade)
        {
            Assert.Throws<ArgumentException>(() => new Produto<int>("Nome", 10.3, quantidade, "categoria"));
        }
    }
}
