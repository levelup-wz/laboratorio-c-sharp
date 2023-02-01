using AutoMapper;
using Comex.Models;
using Comex.Web.Data.Dto;

namespace Comex.Web.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<CriarProdutoDTO, Produto>();
        }
    }
}
