using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces;
using DVAInvest.Domain.Interfaces.Repositories;
using DVAInvest.Infra.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace DVAInvest.Infra.Repository.Repositories;

public class MaterialRepository<TContext> : BaseRepository<TContext, Material>, IMaterialRepository<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private DbSet<Material> _dbSet => ((DVAInvestContext)UnitOfWork).Set<Material>();

    public MaterialRepository(IUnitOfWork<TContext> unitOfWork) : base(unitOfWork) { }
}
