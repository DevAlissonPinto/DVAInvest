using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces;
using DVAInvest.Domain.Interfaces.Repositories;
using DVAInvest.Infra.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace DVAInvest.Infra.Repository.Repositories;

public class PortfolioRepository<TContext> : BaseRepository<TContext, Portfolio>, IPortfolioRepository<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private DbSet<Portfolio> _dbSet => ((DVAInvestContext)UnitOfWork).Set<Portfolio>();

    public PortfolioRepository(IUnitOfWork<TContext> unitOfWork) : base(unitOfWork) { }
}
