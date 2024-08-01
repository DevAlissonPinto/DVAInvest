using DVAInvest.Domain.Entities;

namespace DVAInvest.Domain.Interfaces.Services;

public interface IPortfolioService<TContext> : IBaseService<TContext, Portfolio> where TContext : IUnitOfWork<TContext>
{
}