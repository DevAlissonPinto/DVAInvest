using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces;
using DVAInvest.Domain.Interfaces.Repositories;
using DVAInvest.Infra.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace DVAInvest.Infra.Repository.Repositories;

public class EstoqueRepository<TContext> : BaseRepository<TContext, Estoque>, IEstoqueRepository<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private DbSet<Estoque> _dbSet => ((DVAInvestContext)UnitOfWork).Set<Estoque>();

    public EstoqueRepository(IUnitOfWork<TContext> unitOfWork) : base(unitOfWork) { }

}
