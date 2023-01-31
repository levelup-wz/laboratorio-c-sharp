using AutoMapper;
using Comex.Modelos.Produtos;
using Comex.Web.Data.Dtos;

namespace Comex.Web.Profiles;

public class ProdutoProfile : Profile
{
    public ProdutoProfile()
    {
        CreateMap<CriarProdutoDto, Produto>();
        CreateMap<Produto, LerProdutoDto>();
        CreateMap<AtualizarProdutoDto, Produto>();
        CreateMap<Produto, AtualizarProdutoDto>();
    }
}
