using DVAInvest.Domain.Entities;

namespace DVAInvest.Domain.Interfaces.Services;

public interface IMovimentacaoEstoqueService<TContext> : IBaseService<TContext, MovimentacaoEstoque> where TContext : IUnitOfWork<TContext>
{
}
