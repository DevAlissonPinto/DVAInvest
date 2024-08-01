using DVAInvest.Domain.Entities;

namespace DVAInvest.Domain.Interfaces.Repositories;

public interface IPortfolioRepository<TContext> : IBaseRepository<TContext, Portfolio>
    where TContext : IUnitOfWork<TContext>
{
}
