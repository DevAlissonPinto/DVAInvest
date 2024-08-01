using DVAInvest.Application.Base;
using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces;
using DVAInvest.Domain.Interfaces.Application;
using DVAInvest.Domain.Interfaces.Services;

namespace DVAInvest.Application;

public class UsuarioApplication<TContext> : BaseApplication<TContext, Usuario>, IUsuarioApplication<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private readonly IUsuarioService<TContext> _service;

    public UsuarioApplication(IUnitOfWork<TContext> context, IUsuarioService<TContext> service)
        : base(context, service)
    {
        _service = service;
    }

}