using DVAInvest.Application.Base;
using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces;
using DVAInvest.Domain.Interfaces.Application;
using DVAInvest.Domain.Interfaces.Services;

namespace DVAInvest.Application;

public class EstoqueApplication<TContext> : BaseApplication<TContext, Estoque>, IEstoqueApplication<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private readonly IEstoqueService<TContext> _service;

    public EstoqueApplication(IUnitOfWork<TContext> context, IEstoqueService<TContext> service)
        : base(context, service)
    {
        _service = service;
    }

    public override async Task<Estoque> SaveAsync(Estoque entity)
    {
        await _service.SaveAsync(entity);
        _unitOfWork.Commit();

        return entity;
    }

    public override async Task<Estoque> UpdateAsync(Estoque entity)
    {
        await _service.UpdateAsync(entity);
        _unitOfWork.Commit();

        return entity;
    }
}
