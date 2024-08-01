using DVAInvest.Domain.Entities;

namespace DVAInvest.Domain.Interfaces.Repositories;

public interface IMaterialRepository<TContext> : IBaseRepository<TContext, Material>
    where TContext : IUnitOfWork<TContext>
{
}
