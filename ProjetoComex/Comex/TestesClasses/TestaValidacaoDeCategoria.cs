using Comex.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.TestesClasses
{
    public class TestaValidacaoDeCategoria
    {
        public static void Main ()
        {
            Categoria testeErroID = new Categoria(-1, "Teste de erro ID", "Inativa");
            Categoria testeErroNome = new Categoria(12, "Tes", "Ativa");
            Categoria testeErroCategoria = new Categoria(13, "Teste de Erro Status", "Erro");
            Categoria testeCategoriaSucesso = new Categoria(14, "Teste de categoria", "Inativa");
        }
    }
}
