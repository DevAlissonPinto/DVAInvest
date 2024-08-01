using DVAInvest.Domain.Entities;
using DVAInvest.Web.Models;
using AutoMapper;

namespace DVAInvest.Web.MappingProfile;

public class Mapper : Profile
{
    public Mapper()
    {
        CreateMap<AtivoViewModel, Ativo>().ReverseMap();

        CreateMap<UsuarioViewModel, Usuario>().ReverseMap();
        CreateMap<Usuario, Usuario>();

        CreateMap<EstoqueViewModel, Estoque>().ReverseMap();
        CreateMap<MaterialViewModel, Material>().ReverseMap();
        CreateMap<MovimentacaoEstoqueViewModel, MovimentacaoEstoque>().ReverseMap();
        CreateMap<RespostaBrapiViewModel, RespostaBrapi>().ReverseMap();

        CreateMap<PortfolioViewModel, Portfolio>().ReverseMap();
        CreateMap<Portfolio, Portfolio>();

        CreateMap<PortfolioAtivoViewModel, PortfolioAtivo>().ReverseMap();
        CreateMap<PortfolioAtivo, PortfolioAtivo>()
            .ForMember(dest => dest.Ativo, opt => opt.Ignore()); 

    }
}
