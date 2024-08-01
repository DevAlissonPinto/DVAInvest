using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces.Application.Base;

namespace DVAInvest.Domain.Interfaces.Application;

public interface IPortfolioApplication<TContext> : IBaseApplication<TContext, Portfolio>
where TContext : IUnitOfWork<TContext>
{

}
