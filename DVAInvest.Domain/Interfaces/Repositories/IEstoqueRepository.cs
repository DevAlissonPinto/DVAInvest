using DVAInvest.Domain.Entities;

namespace DVAInvest.Domain.Interfaces.Repositories;

public interface IEstoqueRepository<TContext> : IBaseRepository<TContext, Estoque>
    where TContext : IUnitOfWork<TContext>
{
}
