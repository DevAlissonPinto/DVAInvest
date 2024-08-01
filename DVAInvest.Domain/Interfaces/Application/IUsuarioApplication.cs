using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces.Application.Base;

namespace DVAInvest.Domain.Interfaces.Application;

public interface IUsuarioApplication<TContext> : IBaseApplication<TContext, Usuario>
where TContext : IUnitOfWork<TContext>
{

}