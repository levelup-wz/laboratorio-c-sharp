namespace Comex.Models.Extensoes
{
    public static class ProdutosExtesoes
    {
        public static Produto EncontrarPeloNome(this List<Produto> lista, string nome)
        {
            return lista.First(x => x.Nome.Equals(nome, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
