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
    public class TesteCPF
    {
        [Theory]
        [InlineData("11122233355", "111.222.333-55")]
        [InlineData("01122233300", "011.222.333-00")]
        public void TestaNewCPF(string cpfEntry, string cpfFormated)
        {
            var cpf = new CPF(cpfEntry);

            var formated = cpf.Formatar();

            cpf.ToString().Should().Be(cpfEntry);
            formated.Should().Be(cpfFormated);
        }

        //[Theory]
        //[InlineData("111122233355")] //12
        //[InlineData("1122233355")] // 10
        //[InlineData("a1122233355")] //nonumeric
        //[InlineData(" ")] // space
        //[InlineData("")] // null

        //public void TestaNewCPFFail(string cpfEntry)
        //{
        //    var ActionCpf = () => new CPF(cpfEntry);

        //    ActionCpf.Should().Throw<ArgumentException>().WithMessage("Informe um valor válido para o CPF");
        //}
    }
}
