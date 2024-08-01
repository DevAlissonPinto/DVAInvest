using DVAInvest.Domain.Entities;

namespace DVAInvest.Domain.Interfaces.Repositories;

public interface IMovimentacaoEstoqueRepository<TContext> : IBaseRepository<TContext, MovimentacaoEstoque>
    where TContext : IUnitOfWork<TContext>
{
}
