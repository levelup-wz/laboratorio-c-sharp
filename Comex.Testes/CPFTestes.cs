using Comex.Models;
using Comex.Models.Lib;

using Xunit;

namespace Comex.Testes
{
    public class CPFTestes
    {

        [Fact]
        public void Deve_formatar_o_cpf_quando_o_cpf_estiver_valido()
        {
            var cpf = new CPF("12312312365");

            string cpfFormatado = "123.123.123-65";

            Assert.Equal(cpfFormatado, cpf.Formatar());
        }

        [Fact]
        public void Deve_estourar_exception_se_o_valor_for_invalido()
        {
            Assert.Throws<ArgumentException>(() => new CPF("ABCD123123123"));
        }

    }

}
