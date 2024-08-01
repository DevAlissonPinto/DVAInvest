using DVAInvest.Application;
using DVAInvest.Application.Base;
using DVAInvest.Domain.Interfaces;
using DVAInvest.Domain.Interfaces.Application;
using DVAInvest.Domain.Interfaces.Application.Base;
using DVAInvest.Domain.Interfaces.Repositories;
using DVAInvest.Domain.Services;
using DVAInvest.Infra.Repository.Context;
using DVAInvest.Infra.Repository.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DVAInvest.Domain.Interfaces.Services;

namespace DVAInvest.Infra.Ioc;

public static class AlmoxarifadoIoc
{
    public static void Initialize(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContextPool<DVAInvestContext>(options => options.UseSqlServer(configuration.GetConnectionString("DVAInvestConnection")));
        services.AddScoped<IUnitOfWork<DVAInvestContext>, DVAInvestContext>();

        services.AddScoped(typeof(IBaseApplication<,>), typeof(BaseApplication<,>));
        services.AddScoped(typeof(IBaseService<,>), typeof(BaseService<,>));
        services.AddScoped(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));

        services.AddScoped(typeof(IEstoqueApplication<>), typeof(EstoqueApplication<>));
        services.AddScoped(typeof(IEstoqueService<>), typeof(EstoqueService<>));
        services.AddScoped(typeof(IEstoqueRepository<>), typeof(EstoqueRepository<>));

        services.AddScoped(typeof(IMaterialApplication<>), typeof(MaterialApplication<>));
        services.AddScoped(typeof(IMaterialService<>), typeof(MaterialService<>));
        services.AddScoped(typeof(IMaterialRepository<>), typeof(MaterialRepository<>));

        services.AddScoped(typeof(IMovimentacaoEstoqueApplication<>), typeof(MovimentacaoEstoqueApplication<>));
        services.AddScoped(typeof(IMovimentacaoEstoqueService<>), typeof(MovimentacaoEstoqueService<>));
        services.AddScoped(typeof(IMovimentacaoEstoqueRepository<>), typeof(MovimentacaoEstoqueRepository<>));

        services.AddScoped(typeof(IAtivoApplication<>), typeof(AtivoApplication<>));
        services.AddScoped(typeof(IAtivoService<>), typeof(AtivoService<>));
        services.AddScoped(typeof(IAtivoRepository<>), typeof(AtivoRepository<>));

        services.AddScoped(typeof(IPortfolioApplication<>), typeof(PortfolioApplication<>));
        services.AddScoped(typeof(IPortfolioService<>), typeof(PortfolioService<>));
        services.AddScoped(typeof(IPortfolioRepository<>), typeof(PortfolioRepository<>));

        services.AddScoped(typeof(IUsuarioApplication<>), typeof(UsuarioApplication<>));
        services.AddScoped(typeof(IUsuarioService<>), typeof(UsuarioService<>));
        services.AddScoped(typeof(IUsuarioRepository<>), typeof(UsuarioRepository<>));

        services.AddScoped<IBrapiApplication, BrapiApplication>();
        services.AddScoped<IBrapiService, BrapiService>();

    }

}
