using AutoMapper;
using Comex.Web.Data.Dto;

namespace Comex.Web.Profiles
{
    public class ProdutoProfile :Profile
    {
        public ProdutoProfile()
        {
            CreateMap<CriarProdutoDTO, Produto>();
            CreateMap<Produto, LerProdutoDto>();
            
        }

    }
}
