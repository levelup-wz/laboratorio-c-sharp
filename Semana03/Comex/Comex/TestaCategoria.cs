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
    
        


