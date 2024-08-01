using DVAInvest.Application.Base;
using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces;
using DVAInvest.Domain.Interfaces.Application;
using DVAInvest.Domain.Interfaces.Services;

namespace DVAInvest.Application;

public class AtivoApplication<TContext> : BaseApplication<TContext, Ativo>, IAtivoApplication<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private readonly IAtivoService<TContext> _service;

    public AtivoApplication(IUnitOfWork<TContext> context, IAtivoService<TContext> service)
        : base(context, service)
    {
        _service = service;
    }

}
