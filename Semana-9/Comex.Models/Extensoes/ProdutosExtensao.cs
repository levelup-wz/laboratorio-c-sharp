namespace Comex.Models.Extensoes;

public static class ProdutosExtensao
{
    public static Produto EncontrarPeloNome(this List<Produto> list, string nome)
    {
        var produto = list.FirstOrDefault(p => p.Nome.ToLower() == nome.ToLower());
        return produto;
    }
}
