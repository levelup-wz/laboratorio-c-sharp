using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comex.Entity;

namespace Comex.Test
{
    class TestCategory
    {

        List<Categories> listCategories = new List<Categories>();

        public void ToList()
        {
            Categories category1 = new Categories("INFORMÁTICA", "ATIVA");
            category1.Id = 1;
            Categories category2 = new Categories("MÓVEIS", "INATIVA");
            category2.Id = 2;
            Categories category3 = new Categories("LIVROS", "ATIVA");
            category3.Id = 3;

            listCategories.Add(category1);
            listCategories.Add(category2);
            listCategories.Add(category3);

            Console.WriteLine("1) LISTANDO CATEGORIAS...");
            foreach (Categories value in listCategories)
            {
                Console.WriteLine($"Categoria:  {value.Name} ({value.Id} - {value.Status})");
                Console.WriteLine("-------------------------------------------------------");
            }

        }

    }
}
