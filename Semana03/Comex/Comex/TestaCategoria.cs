using Comex;

namespace Comex
{
    public class CategoriaTeste
    {
        Categoria categoria1 = new Categoria("Informática", "Ativa");
        Categoria categoria2 = new Categoria("Móveis", "Inativa");
        Categoria categoria3 = new Categoria("Livros", "Ativa");
        
        public CategoriaTeste() 
        {
            Console.WriteLine(categoria1.RetornaInfos());
            Console.WriteLine(categoria2.RetornaInfos());
            Console.WriteLine(categoria3.RetornaInfos());
        }

    }
}
    
        



/*namespace Comex
{
    public class TestaCategoria
    {
        Categoria categoria1 = new Categoria("INFORMÁTICA");
        Categoria categoria2 = new Categoria("MÓVEIS", "INATIVA");
        Categoria categoria3 = new Categoria("LIVROS");

        public TestaCategoria()
        {
            Console.WriteLine(categoria1.Informacoes());
            Console.WriteLine(categoria2.Informacoes());
            Console.WriteLine(categoria3.Informacoes());
        }
    }
}*/