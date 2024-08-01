using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces;
using DVAInvest.Domain.Interfaces.Repositories;
using DVAInvest.Infra.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace DVAInvest.Infra.Repository.Repositories;

public class AtivoRepository<TContext> : BaseRepository<TContext, Ativo>, IAtivoRepository<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private DbSet<Ativo> _dbSet => ((DVAInvestContext)UnitOfWork).Set<Ativo>();

    public AtivoRepository(IUnitOfWork<TContext> unitOfWork) : base(unitOfWork) { }
}
