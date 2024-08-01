using DVAInvest.Domain.Entities;

namespace DVAInvest.Domain.Interfaces.Services;

public interface IAtivoService<TContext> : IBaseService<TContext, Ativo> where TContext : IUnitOfWork<TContext>
{
}
