using Comex;

namespace Comex
{
    public class CategoriaTeste
    {
        public static void Main()
        {
            Categoria categoria1 = new Categoria( "Informática", "Ativa");
            Categoria categoria2 = new Categoria( "Móveis", "Inativa");
            Categoria categoria3 = new Categoria(  "Livro", "Ativa");

            Console.WriteLine(categoria1.RetornaInfos());
            Console.WriteLine(categoria2.RetornaInfos());
            Console.WriteLine(categoria3.RetornaInfos());

            
               

            
        }
        
        

    }
}
    
        


