using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces.Application.Base;

namespace DVAInvest.Domain.Interfaces.Application;

public interface IAtivoApplication<TContext> : IBaseApplication<TContext, Ativo>
where TContext : IUnitOfWork<TContext>
{

}
