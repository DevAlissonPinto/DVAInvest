using DVAInvest.Application.Base;
using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces;
using DVAInvest.Domain.Interfaces.Application;
using DVAInvest.Domain.Interfaces.Services;

namespace DVAInvest.Application;

public class MovimentacaoEstoqueApplication<TContext> : BaseApplication<TContext, MovimentacaoEstoque>, IMovimentacaoEstoqueApplication<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private readonly IMovimentacaoEstoqueService<TContext> _service;

    public MovimentacaoEstoqueApplication(IUnitOfWork<TContext> context, IMovimentacaoEstoqueService<TContext> service)
        : base(context, service)
    {
        _service = service;
    }

}
