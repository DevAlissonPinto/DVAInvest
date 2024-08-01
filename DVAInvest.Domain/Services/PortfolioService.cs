using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces;
using DVAInvest.Domain.Interfaces.Repositories;
using DVAInvest.Domain.Interfaces.Services;

namespace DVAInvest.Domain.Services;

public class PortfolioService<TContext> : BaseService<TContext, Portfolio>, IPortfolioService<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private readonly IPortfolioRepository<TContext> _repository;

    public PortfolioService(
                                IPortfolioRepository<TContext> repository,
                                IUnitOfWork<TContext> unitOfWork) : base(repository, unitOfWork)
    {
        _repository = repository;
    }

}
