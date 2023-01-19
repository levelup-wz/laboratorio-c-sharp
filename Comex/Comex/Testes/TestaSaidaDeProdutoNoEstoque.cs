/*using Comex.Categorias;
using Comex.Produtos;
using System;

namespace Comex.Testes
{
    public class TestaSaidaDeProdutoNoEstoque
    {
        Categoria saude = new Categoria("SAUDE", "ATIVA");
        Produto vacina = new ProdutoIsento("Vacina", "Vacinas para todas as doenças",
            (decimal)250.00, 500, saude);

        Estoque estoque = new Estoque();

        estoque.RegistraEntrada(vacina);
        Console.WriteLine($"Entrada: \nCapacidade: {estoque.Capacidade} \nOcupação: {estoque.Ocupacao} \nMontante: {estoque.Montante}");

        estoque.RegistraSaida(vacina);
        Console.WriteLine($"Saída: \nCapacidade: {estoque.Capacidade} \nOcupação: {estoque.Ocupacao} \nMontante: {estoque.Montante}");

        try
        {
            estoque.RegistraSaida(vacina);
        }
        catch(LimiteDeEstoqueExcedidoException ex)
        {
            Console.WriteLine($"Erro do tipo: {ex.Message}");
        }
    }
}
*/