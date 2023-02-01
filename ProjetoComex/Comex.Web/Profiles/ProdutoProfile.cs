using AutoMapper;
using Comex.Entidades;
using Comex.Web.Data.Dto;

namespace Comex.Web.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<CriarProdutoDto, Produto>();
            CreateMap<CriarProdutoDtoCategoria, Produto>();
            CreateMap<Produto, ProdutoDto>();
        }
    }
}
