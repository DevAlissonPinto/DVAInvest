using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces.Application.Base;

namespace DVAInvest.Domain.Interfaces.Application;

public interface IMaterialApplication<TContext> : IBaseApplication<TContext, Material>
where TContext : IUnitOfWork<TContext>
{

}
