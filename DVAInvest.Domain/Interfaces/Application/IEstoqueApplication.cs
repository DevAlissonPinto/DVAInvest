using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces.Application.Base;

namespace DVAInvest.Domain.Interfaces.Application;

public interface IEstoqueApplication<TContext> : IBaseApplication<TContext, Estoque>
where TContext : IUnitOfWork<TContext>
{

}
