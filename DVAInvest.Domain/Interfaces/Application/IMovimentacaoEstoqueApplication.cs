using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces.Application.Base;

namespace DVAInvest.Domain.Interfaces.Application;

public interface IMovimentacaoEstoqueApplication<TContext> : IBaseApplication<TContext, MovimentacaoEstoque>
where TContext : IUnitOfWork<TContext>
{

}
