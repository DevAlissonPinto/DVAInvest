using DVAInvest.Domain.Entities;

namespace DVAInvest.Domain.Interfaces.Services;

public interface IUsuarioService<TContext> : IBaseService<TContext, Usuario> where TContext : IUnitOfWork<TContext>
{
}