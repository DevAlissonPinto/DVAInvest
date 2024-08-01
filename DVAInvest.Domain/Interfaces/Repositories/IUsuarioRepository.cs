using DVAInvest.Domain.Entities;

namespace DVAInvest.Domain.Interfaces.Repositories;

public interface IUsuarioRepository<TContext> : IBaseRepository<TContext, Usuario>
    where TContext : IUnitOfWork<TContext>
{
}