using AutoMapper;
using Comex.Modelos.Produtos;
using Comex.Web.Data.DTOs;

namespace Comex.Web.Profiles;

public class ProdutoProfile : Profile
{
    public ProdutoProfile()
    {
        CreateMap<CriarProdutoDTO, Produto>();
        CreateMap<Produto, LerProdutoDTO>();
    }
}
