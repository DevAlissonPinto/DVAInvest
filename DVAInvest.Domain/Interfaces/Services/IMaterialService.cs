using DVAInvest.Domain.Entities;

namespace DVAInvest.Domain.Interfaces.Services;

public interface IMaterialService<TContext> : IBaseService<TContext, Material> where TContext : IUnitOfWork<TContext>
{
    Task<bool> ValidarMaterialNomeExistente(Material entidade);
    Task<bool> ValidarMaterialCodigoExistente(Material entidade);
}

