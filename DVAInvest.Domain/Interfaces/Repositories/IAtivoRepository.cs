using DVAInvest.Domain.Entities;

namespace DVAInvest.Domain.Interfaces.Repositories;

public interface IAtivoRepository<TContext> : IBaseRepository<TContext, Ativo>
    where TContext : IUnitOfWork<TContext>
{
}
