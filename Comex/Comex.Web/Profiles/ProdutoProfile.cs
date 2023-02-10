using AutoMapper;
using Comex.Web.Data.Dto;
using Comex.Web.Models;

namespace Comex.Web.Profiles;

public class ProdutoProfile : Profile
{
    public ProdutoProfile()
    {
        CreateMap<CriarProdutoDto, Produto>();
        CreateMap<Produto, LerProdutoDto>();
        CreateMap<AtualizarProdutoDto, Produto>();
    }
}
