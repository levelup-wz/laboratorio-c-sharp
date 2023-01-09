using Comex.Entidades;
using Comex.Models.Models;
using FluentAssertions;
using FluentAssertions.Equivalency;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Testes
{
    public class TestNotaFiscal
    {
        public static TheoryData<Produto, Cliente, int, string> TestData = new TheoryData<Produto, Cliente, int, string>
        {
            {
            new Produto("Notebook Sansung", 3523.00, 1, new Categoria("informática")),
            new Cliente("Andre", "Sousa", "12345678922", "7798802-0059", "Rua 1", "10", "Bem querer",
                "Candeias", "Vitoria da Conquista", "Bahia"),
            2,
            $"Numero pedido: {Pedido.numPedido}\n" +
                $"Nome: Andre Sousa\n" +
                $"Data da compra: {DateTime.Now}\n" +
                $"Total do pedido: R$ 7.046,00 => " +
                $"Seven thousand forty six dollar only\n" +
                $"sete mil e quarenta e seis reais"
            }
        };

        [Theory(DisplayName = "Testa o lançamento de uma nova Nota Fiscal com sucesso")]
        [MemberData(nameof(TestData))]
        public void TestNewNotaFiscal(Produto produtoEntry, Cliente clienteEntry, int qtdEntry, string result)
        {
            var pedido = new Pedido(clienteEntry, produtoEntry, qtdEntry);
            pedido.Should().NotBeNull();

            var notaFiscal = new NotaFiscal(pedido);
            notaFiscal.Should().NotBeNull();

            var resultNotaFiscal = notaFiscal.ToString();
            resultNotaFiscal.Should().Be(result);
        }

        
        [Fact(DisplayName = "Teste lançamentos de exceções na classe Nota Fiscal")]
        public void TestFailNotaFiscal()
        {
            var act = () => new NotaFiscal(null);
            act.Should().Throw<ArgumentNullException>();
        }
    }
}
