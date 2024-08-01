using DVAInvest.Application.Base;
using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces;
using DVAInvest.Domain.Interfaces.Application;
using DVAInvest.Domain.Interfaces.Services;

namespace DVAInvest.Application;

public class MaterialApplication<TContext> : BaseApplication<TContext, Material>, IMaterialApplication<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private readonly IMaterialService<TContext> _service;

    public MaterialApplication(IUnitOfWork<TContext> context, IMaterialService<TContext> service)
        : base(context, service)
    {
        _service = service;
    }

    public override async Task<Material> SaveAsync(Material entity)
    {
        await _service.SaveAsync(entity);
        _unitOfWork.Commit();

        return entity;
    }

    public override async Task<Material> UpdateAsync(Material entity)
    {
        await _service.UpdateAsync(entity);
        _unitOfWork.Commit();

        return entity;
    }
}
