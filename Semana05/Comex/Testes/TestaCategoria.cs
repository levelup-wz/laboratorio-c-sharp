using Comex;

namespace Comex
{
    public class CategoriaTeste
    {
        public static void Main()
        {
            //Categoria categoria1 = new Categoria(1, "Informática", "Ativa");
            //Categoria categoria2 = new Categoria(2, "Móveis", "Inativa");
            //Categoria categoria3 = new Categoria( "Livro", "in");

            //Console.WriteLine(categoria1.RetornaInfos());
            //Console.WriteLine(categoria2.RetornaInfos());
            //Console.WriteLine(categoria3.RetornaInfos());

            try
            {
                Categoria categoria1 = new Categoria("livros", "aer");
                

            }catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
               

            
        }
        
        

    }
}
    
        


