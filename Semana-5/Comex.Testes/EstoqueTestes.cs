using Comex.Models;
using FluentAssertions;

namespace Comex.Testes
{
    public class EstoqueTestes
    {
        Estoque estoque = new Estoque();
        ProdutoIsento vacina = new ProdutoIsento("Vacina", 250.00, 500, "Saúde");
        Produto computador = new Produto("Macbook Pro", 20000.00, 15, "Informática");
        [Fact]
        public void RegistraEntrada()
        {
            estoque.RegistraEntrada(vacina);
            estoque.RegistraEntrada(computador);
            estoque.InformacoesDoEstoque().Should().Be($" Capacidade: 485\n Ocupação: 515\n Montante: {425000:C2}");
           
        }
        [Fact]
        public void RegistraSaida()
        {
            estoque.RegistraEntrada(vacina);
            estoque.RegistraEntrada(computador);
            estoque.RegistraSaida(computador);
            estoque.InformacoesDoEstoque().Should().Be($" Capacidade: 500\n Ocupação: 500\n Montante: {125000:C2}");
        }
    }
}
