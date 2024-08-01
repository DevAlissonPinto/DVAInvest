using DVAInvest.Application.Base;
using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces;
using DVAInvest.Domain.Interfaces.Application;
using DVAInvest.Domain.Interfaces.Services;

namespace DVAInvest.Application;

public class PortfolioApplication<TContext> : BaseApplication<TContext, Portfolio>, IPortfolioApplication<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private readonly IPortfolioService<TContext> _service;

    public PortfolioApplication(IUnitOfWork<TContext> context, IPortfolioService<TContext> service)
        : base(context, service)
    {
        _service = service;
    }

}
