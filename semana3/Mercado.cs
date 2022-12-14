using Comex;

class Mercado
{
    //Eu preciso somar o valor dos produtos que vendidos no mercadinho
    // tanto produtoinsento quanto produto normal e retornar o valor

    //DRY - Don't Repeat Yourself
    public double TotalDiario { get; private set; }

    public double SomarValorProdutos(List<Produto> lista)
    {
        var soma = 0.0;
        foreach (Produto item in lista)
        {
            soma += item.PrecoUnitario;
        }
        TotalDiario += soma;
        return soma;
    }
}
